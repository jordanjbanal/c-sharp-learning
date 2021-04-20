using System;

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
int getFirstLetter = name.IndexOf("F");
char firstLetter = name[getFirstLetter];

      // Get last name
int getLastName = name.IndexOf("Hesam");
string lastName = name.Substring(getLastName);

      // Print results
Console.WriteLine($"{firstLetter}. {lastName}");

    }
  }
}
