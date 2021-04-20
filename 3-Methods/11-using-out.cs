using System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
      string outcome = Whisper("HellO", out bool marker);
      Console.WriteLine(outcome);
    } 
    static string Whisper(string statement, out bool marker)
    {
      marker = true;
      return statement.ToLower();
    }
	}
}
