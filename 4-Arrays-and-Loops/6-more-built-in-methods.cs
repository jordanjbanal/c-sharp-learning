using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      string [] summerStrutCopy = new string[8];

      Array.Copy(summerStrut, summerStrutCopy, 8);

      Array.Reverse(summerStrut);

      Array.Clear(ratings, 0, ratings.Length);
    }
  }
}
