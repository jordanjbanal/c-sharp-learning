using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int alarmRing = 0;
      do
      {
        Console.WriteLine("BLARRRRR");
        alarmRing++;
          if(alarmRing == 3)
          {
            break;
          }
      } while(!buttonClick);
    }
  }
}
