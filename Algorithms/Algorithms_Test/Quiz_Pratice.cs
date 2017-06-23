using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Quiz_Pratice;
using System.Collections.Generic;
using Algorithms.Quiz_Practice;

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

        [TestMethod]
        public void Anagrams_Test()
        {
            var testList=new List<string> { "abhishek", "abhshiek" };
            var testIsAnagram = new Anagrams(testList);
            //Assert.AreEqual(true, testIsAnagram.CheckAnagram(),"are anagrams");

            var asciiSum = testIsAnagram.AsciiSum("Sum".ToCharArray());

            var d = new Dictionary<string, bool>();
            var a = new string[] { "a", "b", "c", "d", "longer", "words", "also","d" };

   
                foreach (string s in a)
                {
                    d[s] = true;
                    d.ContainsKey(s);
                }


            var something = "das";
        }
    }
}
