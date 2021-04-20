using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

      var heroName = heroes.Select(h => $"Introducing...{h}!");

      foreach(var h in heroName)
      {
        Console.WriteLine(h);
      }

      var variable2 = from h in heroes
      where h.Contains(" ")
      select h.IndexOf(" ");

      foreach(var h in variable2)
      {
        Console.WriteLine(h);
      }
    }
  }
}
