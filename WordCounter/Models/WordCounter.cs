using System;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string RootWord { get; set; }
    public string Sentence { get; set; }
    public int WordCount { get; set; }
    public RepeatCounter()
    {
      RootWord = "";
      Sentence = "";
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
      string[] sentenceArray = input.Split(' ');
      bool outcome = false;
      foreach (string word in sentenceArray)
      {
        outcome = word.All(Char.IsLetter);
        if (!outcome)
        {
          break;
        }
      }
      return outcome;
    }


  }
}