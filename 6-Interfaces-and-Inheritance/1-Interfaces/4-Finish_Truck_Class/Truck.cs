using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {
  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set;}

    public int Wheels
    { get; }

    public double Weight 
    { get; }
     
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed-= 5;
    }

    public Truck(double speed, double weight)
    {
      Speed = speed;
      Weight = weight;
      LicensePlate = Tools.GenerateLicensePlate();
      if(Weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }

  }
}