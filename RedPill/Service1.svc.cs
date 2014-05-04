using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RedPill
{
  [DataContract(Namespace="http://KnockKnock.readify.net")]
  public class ContactDetails
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

  [DataContract(Namespace="http://KnockKnock.readify.net")]
  public enum TriangleType 
  { 
    [EnumMember] 
    Error,
    [EnumMember]
    Equilateral,
    [EnumMember]
    Isosceles,
    [EnumMember]
    Scalene
  }

  [ServiceContract(Namespace="http://KnockKnock.readify.net")]
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

  [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
  public class RedPill : IRedPill
  {
    private static double Phi = ((1d + Math.Sqrt(5d)) / 2d);
    private static double D = 1d / Math.Sqrt(5d);

    public long FibonacciNumber(long n)
    {
      if (!(-92 <= n && n <= 92)) Fault(new ArgumentOutOfRangeException("n", "Require 0 <= n <= 92"));

      if (n < 0) return (long)Math.Pow(-1, -n + 1) * FibonacciNumber(-n);
      return (long)((Math.Pow(Phi,n) - Math.Pow(1d - Phi, n)) * D);
    }

    public string ReverseWords(string s)
    {
      if (s == null) Fault(new ArgumentNullException("s", "Require s != null"));

      var result = new StringBuilder(s.Length);

      int start = 0;

      while (start < s.Length)
      {
        int end = start;
        while (end < s.Length && !Char.IsWhiteSpace(s[end])) end++;

        for (int i = end - 1; i >= start; i--) result.Append(s[i]);

        start = end;
        while (start < s.Length && Char.IsWhiteSpace(s[start])) result.Append(s[start++]);
      }
      
      
      return result.ToString();
    }

    public TriangleType WhatShapeIsThis(int a, int b, int c)
    {
      if (a <= 0 || b <= 0 || c <= 0) return TriangleType.Error;
      else if (!(a < b + c && b < a + c && c < a + b)) return TriangleType.Error;
      else if (a == b && b == c) return TriangleType.Equilateral;
      else if (a == b || a == c || b == c) return TriangleType.Isosceles;
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

    void Fault<T>(T detail) where T : Exception
    {
      throw new FaultException<T>(detail, detail.Message);
    }
  }
}
