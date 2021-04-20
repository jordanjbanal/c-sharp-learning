using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		
      Rover[] theRovers = new Rover[] {lunokhod, apollo, sojourner};


      Object o1 = lunokhod;
      Object o2 = apollo;
      Object o3 = sojourner;
      Object o4 = sputnik;
      Object[] objects = new Object[] {o1, o2, o3, o4};

      foreach(Object o in objects)
      {
        Console.WriteLine($"Tracking a {o.GetType()}...");
      }

      IDirectable[] theDirectables = new IDirectable[] {lunokhod, apollo, sojourner, sputnik};

      DirectAll(theDirectables);

    }
    
    public static void DirectAll(IDirectable[] theDirectables)
    {
      foreach(IDirectable r in theDirectables)
      {
        Console.WriteLine(r.GetInfo());
        Console.WriteLine(r.Explore());
        Console.WriteLine(r.Collect());
      }
    }


  }
}
