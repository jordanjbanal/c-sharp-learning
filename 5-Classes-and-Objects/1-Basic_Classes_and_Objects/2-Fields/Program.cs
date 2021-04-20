using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Amazon";
      f.trees = 4;
      f.age = 2;
      f.biome = "Tropical";

      Console.WriteLine(f.name);
    }
  }
}
