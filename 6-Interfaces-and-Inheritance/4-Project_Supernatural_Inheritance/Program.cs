using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      //Array declaration and initiation, keeping track of 
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;
      //Adding objects to array
      storms[0] = new Storm("wind", false, "Zul'rajas");
      storms[1] = new Pupil("Mezil-kree");
      storms[2] = new Mage("Gul'dan");
      storms[3] = new Archmage("Nielas Aran");

      //Loop through the array to "Announce()" and print 
      for(int i = 0; i < storms.Length; i++)
      {
        Console.WriteLine(storms[i].Announce());
      }
      // Storm s = new Storm("wind", false, "Zul'rajas");
      Console.WriteLine(s.Announce());

      //Pupil p = new Pupil("Mezil-kree");
      Storm pupilCastWind = p.CastWindStorm();
      Console.WriteLine(pupilCastWind.Announce());

      //Mage m = new Mage("Gul'dan");
      Storm theMage = m.CastRainStorm();
      Console.WriteLine(theMage.Announce());
      //Archmage a = new Archmage("Nielas Aran");
      Storm castRain = a.CastRainStorm();
      Console.WriteLine(castRain.Announce());
      Storm castLightning = a.CastLightningStorm();
      Console.WriteLine(castLightning.Announce());
    }
  }
}