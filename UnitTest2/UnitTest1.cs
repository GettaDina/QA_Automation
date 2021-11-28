using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertingNumber;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void BoundaryCondition()
        {
            string[] argsLeft = {"187", "20"};            
            string[] argsRight = {"187", "2"};            
            Assert.AreEqual("97", Transform.TransitionToNewNumberSystem(argsLeft));
            Assert.AreEqual("10111011", Transform.TransitionToNewNumberSystem(argsRight));
        }       
        [TestMethod]
        public void IncorrectNewBase()
        {
            string[] args = {"4", "21"};            
            Assert.ThrowsException<System.Exception>(() => Transform.TransitionToNewNumberSystem(args));            
        }
        [TestMethod]
        public void InvalidNumberOfArguments()
        {
            string[] args = {"1", "2", "3"};
            Assert.ThrowsException<System.Exception>(() => Transform.TransitionToNewNumberSystem(args));
        }
        [TestMethod]
        public void DataCorrectness()
        {
            string[] args = { "a", "4"};
            Assert.ThrowsException<System.Exception>(() => Transform.TransitionToNewNumberSystem(args));
        }

    }
}
