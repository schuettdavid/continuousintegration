using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFunctions;

namespace SimpleFunctions.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(5, Calculator.Add(2, 3));
        }
    }
}
