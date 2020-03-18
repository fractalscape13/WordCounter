using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string RootWord { get; set; }
    public string[] Sentence { get; set; }
    public int WordCount { get; set; }
    public RepeatCounter()
    {
      RootWord = "";
      Sentence = new string[] { };
      WordCount = 0;
    }

    public List<string> Dictionary = File.ReadAllLines("/Users/Guest/Desktop/WordCounter.Solution/newDictionary.txt").ToList();

    public bool DictionaryCheck(string input)
    {
      bool outcome = false;
      foreach (string entry in Dictionary)
      {
        if (entry == input)
        {
          outcome = true;
          break;
        }
      }
          return outcome;
    }

    public bool ValidateWord(string input)
    {
      bool outcome = input.All(Char.IsLetter);
      if (outcome)
      {
        RootWord = input.ToLower();
      }
      return outcome;
    }

    public bool ValidateSentence(string input)
    {
      string lowerSentence = input.ToLower();
      char[] specialChar = {'.', ',', '!', '?', '-', '@', '#', '$', '_', '`', '~', ';', ':', '/', '%', '^', '&', '*', '(', ')'};
      char spaceChar = ' ';
      foreach (char symbol in specialChar)
      {
        if (lowerSentence.Contains(symbol))
        {
          lowerSentence = lowerSentence.Replace(symbol, spaceChar);
        }
      }
      Sentence = lowerSentence.Split(' ');
      bool outcome = false;
      foreach (string word in Sentence)
      {
        outcome = word.All(Char.IsLetter);
        if (!outcome)
        {
          break;
        }
      }
      return outcome;
    }

    public int CountWords()
    {
      foreach (string word in Sentence)
      {
        if (word == RootWord)
        {
          WordCount++;
        }
      }
      return WordCount;
    }
  }
}