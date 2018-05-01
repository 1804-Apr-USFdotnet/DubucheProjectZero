using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalandromeCodeChallenge;

namespace Palandrome.TEST
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            bool Word = Program.IsPalindrome("racecar");

        }
    }
}
