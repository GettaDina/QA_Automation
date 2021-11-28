using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace UnitTestBooks
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void OneLetter()
        {
            string[] str = {"a"};
            int result = SymbolComparison.MaxNumberOfNonRepearingSymbol(str);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void RepeatOnly()
        {
            string[] str = {"aaaaaaaaaaaaaaaaaaaaa"};
            int result = SymbolComparison.MaxNumberOfNonRepearingSymbol(str);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void UpperLowerCase()
        {
            string[] str = {"QqaAuUKkTtRrVv"};
            int result = SymbolComparison.MaxNumberOfNonRepearingSymbol(str);
            Assert.AreEqual(14, result);
        }

    }
}
