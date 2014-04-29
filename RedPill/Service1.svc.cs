using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RedPill
{
  [DataContract]
  public struct ContactDetails
  {
    [DataMember]
    public string EmailAddress;
    [DataMember]
    public string FamilyName;
    [DataMember]
    public string GivenName;
    [DataMember]
    public string PhoneNumber;
  }

  public enum TriangleType { Error, Equilateral, Isoceles, Scalene }

  [ServiceContract]
  public interface IRedPill
  {
    [OperationContract, FaultContract(typeof(ArgumentOutOfRangeException))]
    long FibonacciNumber(long n);
    [OperationContract, FaultContract(typeof(ArgumentNullException))]
    string ReverseWords(string s);
    [OperationContract]
    TriangleType WhatShapeIsThis(int a, int b, int c);
    [OperationContract]
    ContactDetails WhoAreYou();
  }

  public class RedPill : IRedPill
  {

    public long FibonacciNumber(long n)
    {
      if (n < 0) throw new ArgumentOutOfRangeException();
      
      return n < 2 ? n : FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
    }

    public string ReverseWords(string s)
    {
      if (s == null) throw new ArgumentNullException();

      var result = new StringBuilder(s.Length);
      for (int i = s.Length; i >= 0; i-- )
        result.Append(s[i]);
      return result.ToString();
    }

    public TriangleType WhatShapeIsThis(int a, int b, int c)
    {
      if (a <= 0 || b <= 0 || c <= 0) return TriangleType.Error;
      else if (a == b && b == c) return TriangleType.Equilateral;
      else if (a == b || a == c) return TriangleType.Isoceles;
      else return TriangleType.Scalene;
    }

    public ContactDetails WhoAreYou()
    {
      return new ContactDetails()
      {
        EmailAddress = "gavin@almostpurple.com",
        FamilyName = "Morris",
        GivenName = "Gavin",
        PhoneNumber = "0403 508 862"
      };
    }
  }
}
