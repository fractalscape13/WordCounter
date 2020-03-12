using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void ValidateWord_CheckForLettersOnly_True()
    {
      RepeatCounter newCount = new RepeatCounter();
      string input = "sample";
      bool result = newCount.ValidateWord(input);
      Assert.AreEqual(true, result);
    }
    
    [TestMethod]
    public void ValidateSentence_CheckForLettersOnly_True()
    {
      RepeatCounter newCount = new RepeatCounter();
      string input = "This is a sample sentence";
      bool result = newCount.ValidateSentence(input);
      Assert.AreEqual(true, result);
    }
    
    [TestMethod]
    public void CountWords_CheckForOccurences_Int()
    {
      RepeatCounter newCount = new RepeatCounter();
      string inputSent = "This sample is a sample of a sample sentence";
      string inputWord = "sample";
      newCount.ValidateSentence(inputSent);
      newCount.ValidateWord(inputWord);
      int result = newCount.CountWords();
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void CountWords_DontCountWordsContainedInOtherWords_Int()
    {
      RepeatCounter newCount = new RepeatCounter();
      string inputSent = "A cat named cat cathy came into my cathedral";
      string inputWord = "cat";
      newCount.ValidateSentence(inputSent);
      newCount.ValidateWord(inputWord);
      int result = newCount.CountWords();
      Assert.AreEqual(1, result);
    }
  }
}