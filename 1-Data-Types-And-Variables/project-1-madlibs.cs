using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is meant to tell a story based on user input to fill the gaps
      Author: Jordan
      */


      // Let the user know that the program is starting:
Console.WriteLine("The game has just started!");

      // Give the Mad Lib a title:
      string title = "Mad Libs";

      Console.WriteLine(title);
      // Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();
Console.Write("Pick a color: ");
string color = Console.ReadLine();
Console.Write("Choose an adjective describing a feeeling: ");
string feeling = Console.ReadLine();
Console.Write("Choose a texture between \"soft\" and \"hard\".");
string texture = Console.ReadLine();
Console.Write("Pick a verb representing an action: ");
string verb = Console.ReadLine();
Console.Write("Pick two nouns like \"a girl\", \"a cabin\", \"A toaster\": ");
string noun1 = Console.ReadLine();
string noun2 = Console.ReadLine();
Console.Write("Pick an animal: ");
string animal = Console.ReadLine();
Console.Write("Pick a food: ");
string food = Console.ReadLine();
Console.Write("Pick a fruit ");
string fruit = Console.ReadLine();
Console.Write("Pick a superhero: ");
string superhero = Console.ReadLine();
Console.Write("Pick a country: ");
string country = Console.ReadLine();
Console.Write("Pick a dessert: ");
string dessert = Console.ReadLine();
Console.Write("Pick a year: ");
string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {color} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. _ woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
Console.WriteLine(story);
    }
  }
}
