using System;

namespace LearnInheritance
{
  class Bicycle : Vehicle
  {

    public Bicycle(double speed) : base(speed)
    {
      Wheels = 2;
    }

    public override void SpeedUp()
    {
      Speed += 5;
      
      if (Speed > 15)
      {
        Speed = 15;
      }
    }

    public override void SlowDown()
    {
      Speed -= 5;

      if (Speed < 0)
      {
        Speed = 0;
      }
    }

    public override string Describe()
    {
      Console.WriteLine($"The bicycle is immatriculated: {LicensePlate}, the speed is: {Speed} and the number of wheels are: {Wheels}.");
    }

  }
}