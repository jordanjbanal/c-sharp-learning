using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.Write("Pick an amount of cents to break down into gold, silver and bronze coins: ");
      double pickedNumber = Convert.ToDouble(Console.ReadLine());
      double numberOfGoldCoins = Math.Floor(pickedNumber / 10);
      double remainder1 = pickedNumber % 10;
      double numberOfSilverCoins = Math.Floor(remainder1 / 5);
      double numberOfBronzeCoins = pickedNumber % 5;

Console.WriteLine($"There are {numberOfGoldCoins} gold coin(s), {numberOfSilverCoins} silver coin(s) and {numberOfBronzeCoins} bronze coin(s).");

      
    }
  }
}
