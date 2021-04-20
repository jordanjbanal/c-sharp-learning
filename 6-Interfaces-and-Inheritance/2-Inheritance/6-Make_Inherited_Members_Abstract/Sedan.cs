using System;

namespace LearnInheritance
{
  class Sedan : Vehicle, IAutomobile
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }
    
    public override string Describe()
    {
      Console.WriteLine($"This Sedan is immatriculated: {LicensePlate}, the speed is: {Speed} and the number of wheels are: {Wheels}.");
    }
  }
}