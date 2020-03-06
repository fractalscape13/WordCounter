using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void firstttest()
    {
      RepeatCounter newCount = new RepeatCounter();
      string input = "sample";
      bool result = newCount.ValidateWord(input);
      Assert.AreEqual(true, result);
    }
  }
}