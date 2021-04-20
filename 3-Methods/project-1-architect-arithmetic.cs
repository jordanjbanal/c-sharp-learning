using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double totalCostOfArea = (Rectangle(1500, 2500) + Circle(375) + Triangle(500, 750) * 180);
      Console.WriteLine($"This is the total cost in Pesos of the area: {Math.Round(totalCostOfArea, 2)}");
    }
    static double Rectangle(double length, double width)
    {
      return length * width;
    }

    static double Circle(double radius)
    {
      return (Math.PI * Math.Pow(radius, 2)) / 2;
    }

    static double Triangle(double bottom, double height)
    {
      return (0.5 * bottom * height) / 2;
    }

  }
}
