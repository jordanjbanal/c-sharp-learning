using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"Was the date of the arrival of the plague in England 1346?", "Is French Guyana situated in Latin America?", "Is Elon Musk CEO of SpaceX and Tesla?"};
      bool[] answers = {true, false, true};
      bool[] responses = new bool[questions.Length];

      if(questions.Length != answers.Length)
      {
        Console.WriteLine("The \"question\" and \"answers\" arrays are not equal in size.");
      }
      int askingInput = 0;

  foreach(string question in questions)
  {
    string input;
    bool isBool;
    bool inputBool;

    Console.WriteLine(question);
    Console.WriteLine("True or False?");
    input = Console.ReadLine();
    isBool = Boolean.TryParse(input, out inputBool);
    while(isBool != true)
    {
      Console.WriteLine("Please respond with 'true' or 'false'.");
      input = Console.ReadLine();
      isBool = Boolean.TryParse(input, out inputBool);
    }
    responses[askingInput] = inputBool;
    Console.WriteLine(responses[askingInput]);
  }
  int scoringIndex = 0;
  int score = 0;

  foreach(bool answer in answers)
  {
    bool response = responses[scoringIndex];
    Console.WriteLine($"{scoringIndex + 1} Input: {response} | Answer: {answer}");
    scoringIndex++;
    if(answer == response)
    {
      score++;
    }
  }
  Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
