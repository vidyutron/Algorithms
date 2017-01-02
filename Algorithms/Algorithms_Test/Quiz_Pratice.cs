using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Quiz_Pratice;
using System.Collections.Generic;

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

        [TestMethod]
        public void SubArray_Sum_Test()
        {
            var firstString = new List<int>{ 1, 2, 3 };
            var lcs = new SubArray_Sum(firstString);
            var lcsReturn = lcs.Summation();
        }
    }
}
