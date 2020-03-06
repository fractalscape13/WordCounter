using System;
using WordCounter.Models;

namespace WordCounter
{
  class Program
  {
    public static void Main()
    {
      Console.Clear();
      TypeLine("Welcome to the Word Counter program");
      TypeLine("Please enter a single word (no numbers, spaces or special characters please)");
      string inputWord = Console.ReadLine();
      Console.Clear();
      TypeLine("Please enter a sentence (no numbers, punctuation or special characters please)");
      string inputSent = Console.ReadLine();
      RepeatCounter newCount = new RepeatCounter();
      newCount.ValidateWord(inputWord);
      newCount.ValidateSentence(inputSent);
      int result = newCount.CountWords();
      Console.Clear();
      if (result == 1)
      {
        TypeLine("The word '" + newCount.RootWord + "' appears in the sentence you entered only " + result + " time. Yay!");
      }
      else
      {
        TypeLine("The word '" + newCount.RootWord + "' appears in the sentence you entered " + result + " times. Yay!");
      }


    }

    public static void TypeLine(string input)
    {
      for (int i = 0; i < input.Length; i++)
      {
          Console.Write(input[i]);
          System.Threading.Thread.Sleep(25);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
    }
  }
}