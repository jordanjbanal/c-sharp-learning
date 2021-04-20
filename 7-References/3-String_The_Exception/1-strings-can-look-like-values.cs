using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "immutable";
      string s2 = "immutable";

      Console.WriteLine(s1 == s2);

      Object o1 = new Object();
      Object o2 = new Object();

      Console.WriteLine(o1 == o2);
    }
  }
}
