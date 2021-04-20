using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        int minLength = 8;
        string lowercase = "qwertyuiopasdfghjklzxcvbnm";
        string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string digits = "1234567890";
        string specialChar = "!@#$%^&*()_+{}|[];:,.<>?`~";

        string userInput = Console.ReadLine();

        int score = 0;
        if (userInput.Length >= minLength)
        {
          score++;
        }
        if(Tools.Contains(userInput, lowercase))
        {
          score++;
        }
        if(Tools.Contains(userInput, uppercase))
        {
          score++;
        }
        if(Tools.Contains(userInput, digits))
        {
          score++;
        }
        if(Tools.Contains(userInput, specialChar))
        {
          score++;
        }
Console.WriteLine(score);

switch(score)
{
  case 5:
  Console.WriteLine("The password is extremely strong");
  break;

  case 4:
  Console.WriteLine("The password is extremely strong");
  break;

  case 3:
    Console.WriteLine("The password is strong");
  break;

  case 2:
    Console.WriteLine("The password is medium");
  break;

  case 1:
    Console.WriteLine("The password is weak");
  break;

  default:
    Console.WriteLine("The password did not meet any standards");
  break;
}

    }
  }
}
