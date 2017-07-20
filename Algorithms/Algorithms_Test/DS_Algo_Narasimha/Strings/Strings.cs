using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_Algo_Narasimha.Strings;
using DS_Algorithm_Narasimha.Strings;

namespace Algorithms_Test.DS_Algo_Narasimha.Strings
{
    [TestClass]
    public class Strings
    {
        [TestMethod]
        public void LongestPlaindromeSubString()
        {
            var tempPlain = new Palindrome("forgeeksskeegfor");
            Assert.AreEqual("geeksskeeg", tempPlain.LongestPalindromeSubString());
        }

        [TestMethod]
        public void LongestNonRepeatingSubstring()
        {
            var tempNRS = new LongestSubstringNR("GEEKFORFGEEK");
            var result=tempNRS.LongestNonRepeatingSubstring();
        }
    }
}
