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
      string input = "This i4s a sample sentence";
      bool result = newCount.ValidateSentence(input);
      Assert.AreEqual(true, result);
    }
  }
}