using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("Write your message here:");
      string message = Console.ReadLine();
      string messageLower = message.ToLower();
      char[] secretMessage = messageLower.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        char secretChar = secretMessage[i];
        if (Array.IndexOf(alphabet, secretChar) >= 0)
        {
          int secretCharIndex = Array.IndexOf(alphabet, secretChar);
          int encryptedCharIndex = (secretCharIndex + 3) % alphabet.Length;
          char encryptedChar = alphabet[encryptedCharIndex];
          encryptedMessage[i] = encryptedChar;
        }
        else
        {
          continue;
        }
      }

      Console.WriteLine(String.Join("", encryptedMessage));



    }
  }
}