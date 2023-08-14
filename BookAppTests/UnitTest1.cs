using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace BookAppTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "IM ALIVE";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw =  new StringWriter ())
            {
                Console.SetOut(sw);
                // BlazorApp1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}