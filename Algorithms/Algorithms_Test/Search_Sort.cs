using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Search_Sort;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_Test
{
    [TestClass]
    public class Search_Sort
    {
        [TestMethod]
        public void Selection_Sort_Test()
        {
            var inputList = new List<int> { 6, 78, 3, 2, 9, 23, 67 };
            var sortedList = new List<int> { 2, 3, 6, 9, 23, 67, 78 };
            var selectionSort = new Selection_Sort<int>(inputList);
            //var inputList = new List<string> { "goat","diablo","bomb","yeti" };
            //var sortedList = new List<string> { "bomb", "diablo", "goat", "yeti" };
            //var selectionSort = new Selection_Sort<string>(inputList);
            Assert.IsTrue(selectionSort.Sort().SequenceEqual(sortedList), "Selection sort is working as expected");
        }

        [TestMethod]
        public void Bubble_Sort_Test()
        {
            var inputList = new List<int> { 6, 78, 3, 2, 9, 23, 67 };
            var sortedList = new List<int> { 2, 3, 6, 9, 23, 67, 78 };
            var bubbleSort = new Bubble_Sort<int>(inputList);
            //var inputList = new List<string> { "goat","diablo","bomb","yeti" };
            //var sortedList = new List<string> { "bomb", "diablo", "goat", "yeti" };
            //var selectionSort = new Selection_Sort<string>(inputList);
            Assert.IsTrue(bubbleSort.Sort().SequenceEqual(sortedList), "Selection sort is working as expected");
        }
    }
}
