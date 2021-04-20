using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

/*

        foreach(Language l in languages)
        {
          Console.WriteLine(l.Prettify());
        }
*/
        var stringOfLanguage = languages.Select(l => $"The language {l.Name} founded by {l.ChiefDeveloper} was developed in {l.Year}");
/*
        foreach(var s in stringOfLanguage)
        {
          Console.WriteLine(s);
        }
*/
        var useOfCSharp = languages
        .Where(l => l.Name == "C#")
        .Select(l => l.Prettify());

        foreach(var l in useOfCSharp)
        {
          Console.WriteLine(l);
        }
    }
  }
}
