using System;

namespace LearnInheritance
{
  class Bicycle : Vehicle
  {
    public Bicycle (double Speed) : base(speed)
    {
      Speed = speed;
      Wheels = 2;
    }

    public override void SpeedUp()
    {
      Speed += 5;
      if (speed > 15)
      {
        Speed = 15;
      }
    }

    public override void SlowDown()
    {
      Speed -= 5;
      if(Speed < 0)
      {
        Speed = 0;
      }
    }
  }
}