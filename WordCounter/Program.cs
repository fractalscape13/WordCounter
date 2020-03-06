using System;
using WordCounter.Models;

namespace WordCounter
{
  class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      TypeLine("Welcome to the Word Counter program");
      string inputWord = GetWord();
      string inputSent = GetSentence();
      RepeatCounter newCount = new RepeatCounter();
      bool wordValid = newCount.ValidateWord(inputWord);
      bool sentValid = newCount.ValidateSentence(inputSent);
      if (wordValid && sentValid)
      {
        int result = newCount.CountWords();
        Console.Clear();
        Console.Write(Environment.NewLine);
        if (result == 1)
        {
          TypeLine("The word '" + newCount.RootWord + "' appears in the sentence you entered only " + result + " time. Yay!");
          PlayAgain();
        }
        else
        {
          TypeLine("The word '" + newCount.RootWord + "' appears in the sentence you entered " + result + " times. Yay!");
          PlayAgain();
        }
      }
      else
      {
        if (!wordValid)
        {
          ErrorMessage("word");
        }
        else if (!sentValid)
        {
          ErrorMessage("sentence");
        }
      }
    }

    public static string GetWord()
    {
      TypeLine("Please enter a single word (no numbers, spaces or special characters please)");
      string inputWord = Console.ReadLine();
      return inputWord;
    }

    public static string GetSentence()
    {
      Console.Write(Environment.NewLine);
      TypeLine("Please enter a sentence (no numbers, punctuation or special characters please)");
      string inputSent = Console.ReadLine();
      return inputSent;
    }

    public static void PlayAgain()
    {
      TypeLine("Would you like to enter a new word and sentence? Enter yes or no");
      string response = Console.ReadLine();
      if (response.ToLower() == "yes" || response.ToLower() == "y")
      {
        Main();
      }
      else 
      {
        Console.Write(Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.Magenta;
        TypeLine("Okay, thanks for using the Word Counter! Bye!");
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

    public static void ErrorMessage(string error)
    {
      Console.Write(Environment.NewLine);
      Console.ForegroundColor = ConsoleColor.Red;
      if (error == "word")
      {
        TypeLine("Your WORD wasn't valid, please use ONLY letters. Don't include any spaces, numbers or special characters. Let's try again in....");
      }
      else if (error == "sentence")
      {
        TypeLine("Your SENTENCE wasn't valid, please use ONLY letters. Don't include any punctuation, numbers or special characters. Let's try again in...");
      }
      TypeLine("3........................");
      System.Threading.Thread.Sleep(400);
      TypeLine("2..................................");
      System.Threading.Thread.Sleep(400);
      TypeLine("4...........................................");
      System.Threading.Thread.Sleep(800);
      Main(); 
    }
  }
}