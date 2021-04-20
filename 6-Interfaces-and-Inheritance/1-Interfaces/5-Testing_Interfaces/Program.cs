using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Sedan d = new Sedan(70);
      Truck t = new Truck(45, 500);

      Console.WriteLine($"The speed is {s.Speed}, the number of wheels is {s.Wheels}, the license plate number is : {s.LicensePlate}");

      Console.WriteLine($"The speed is {d.Speed}, the number of wheels is {d.Wheels}, the license plate number is : {d.LicensePlate}");

      Console.WriteLine($"The speed is {t.Speed}, the number of wheels is {t.Wheels}, the license plate number is : {t.LicensePlate}");

      s.SpeedUp();
      d.SpeedUp();
      t.SpeedUp();

Console.WriteLine($"The new speed is {s.Speed}");

Console.WriteLine($"The new speed is {d.Speed}");

Console.WriteLine($"The new speed is {t.Speed}");

    }
  }
}