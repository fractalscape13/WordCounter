using System;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string RootWord { get; set; }
    public string[] Sentence { get; set; }
    public int WordCount { get; set; }
    public string[] sentence = { };
    public RepeatCounter()
    {
      RootWord = "";
      Sentence = sentence;
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
      string lowerCase = input.ToLower();
      Sentence = lowerCase.Split(' ');
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