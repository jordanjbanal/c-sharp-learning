using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      string output = DecoratePlanet("Jupiter");
      Console.WriteLine(output);
    }
    static string DecoratePlanet(string planetName)
    {
      string message = $"Welcome to {planetName}";
      return message;
    }
	}
}
