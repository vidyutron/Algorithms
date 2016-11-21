using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Quiz_Pratice;

namespace Algorithms_Test
{
    [TestClass]
    public class Quiz_Pratice
    {
        [TestMethod]
        public void LongestCommonSubString_Test()
        {
            var firstString = "fahsdchasdhcajshdcjahsdchasdjcasjch";
            var secondString = "asjbfdhcajshskjdfna";
            var lcs = new LongestCommonSubString(firstString, secondString);
            var lcsReturn=lcs.SubStringMatch();
        }
    }
}
