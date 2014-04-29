using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPillClient
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var client = new Readify.RedPillClient())
      {
        Console.WriteLine("[" + client.ReverseWords("") + "]");
      }
    }
  }
}
