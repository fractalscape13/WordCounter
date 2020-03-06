using System;
using System.Linq;

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