using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("Secret message: ");
      string message = Console.ReadLine();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

    for(int i = 0; i < secretMessage.Length; i++)
    {
      char character = secretMessage[i];
      int characterPosition = Array.IndexOf(alphabet, character);
      char newCharacter = alphabet[(characterPosition + 3) % alphabet.Length];
      encryptedMessage[i] = newCharacter;
    }
    string theEncryptedMessage = String.Join("", encryptedMessage);
    Console.WriteLine(theEncryptedMessage);
    }
  }
}