using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Dissertation diss = new Dissertation();
			IFlippable fdiss = diss;
      Book bdiss = diss;
			fdiss.CurrentPage = 42;
      Console.WriteLine(fdiss == bdiss);
    }
  }
}
