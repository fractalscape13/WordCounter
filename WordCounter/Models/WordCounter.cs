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
      string[] words = { };
      Sentence = words;
      WordCount = 0;
    }

    public bool ValidateWord(string input)
    {
      bool outcome = input.All(Char.IsLetter);
      if (outcome)
      {
        RootWord = input;
      }
      return outcome;
    }

    public bool ValidateSentence(string input)
    {
      Sentence = input.Split(' ');
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