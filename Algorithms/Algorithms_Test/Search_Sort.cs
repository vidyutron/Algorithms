using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Search_Sort;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Search_Sort.Scenarios;

namespace Algorithms_Test
{
    [TestClass]
    public class Search_Sort
    {
        private List<int> _inputList;
        private List<int> _sortedList;

        [TestInitialize]
        public void TestInit()
        {
            _inputList = new List<int> { 6, 78, 3, 2, 9, 23, 67 };
            _sortedList = new List<int> { 2, 3, 6, 9, 23, 67, 78 };
        }

        [TestMethod]
        public void Selection_Sort_Test()
        {
            var selectionSort = new Selection_Sort<int>(_inputList);
            Assert.IsTrue(selectionSort.Sort().SequenceEqual(_sortedList), "Selection sort is working as expected");
        }

        [TestMethod]
        public void Bubble_Sort_Test()
        {
            var bubbleSort = new Bubble_Sort<int>(_inputList);
            Assert.IsTrue(bubbleSort.Sort().SequenceEqual(_sortedList), "Bubble sort is working as expected");
        }

        [TestMethod]
        public void Insertion_Sort_Test()
        {
            var insertionSort = new Insertion_Sort<int>(_inputList);
            Assert.IsTrue(insertionSort.Sort().SequenceEqual(_sortedList), "Insertion sort is working as expected");
        }

        [TestMethod]
        public void Merge_Sort_Test()
        {
            var mergeSort = new Merge_Sort<int>(_inputList);
            Assert.IsTrue(mergeSort.Sort().SequenceEqual(_sortedList), "Merge sort is working as expected");
        }

        [TestMethod]
        public void Heap_Sort_Test()
        {
            var heapSort = new Heap_Sort<int>(_inputList);
            Assert.IsTrue(heapSort.Sort().SequenceEqual(_sortedList), "Heap sort is working as expected");
        }

        [TestMethod]
        public void Quick_Sort_Test()
        {
            var quickSort = new Quick_Sort<int>(_inputList);
            Assert.IsTrue(quickSort.Sort().SequenceEqual(_sortedList), "Heap sort is working as expected");
        }
        [TestMethod]
        public void Radix_Sort_Test()
        {
            var radixSort = new Radix_Sort(_inputList,_inputList.Count);
            Assert.IsTrue(radixSort.Sort().SequenceEqual(_sortedList), "Radix sort is working as expected");
        }

        [TestMethod]
        public void Bucket_Sort_Test()
        {
            var bucketSort = new Bucket_Sort<int>(_inputList, 10);
            Assert.IsTrue(bucketSort.Sort().SequenceEqual(_sortedList), "Bucket sort is working as expected");
        }

        [TestMethod]
        public void Shell_Sort_Test()
        {
            var shellSort = new Shell_Sort<int>(_inputList);
            Assert.IsTrue(shellSort.Sort().SequenceEqual(_sortedList), "Shell sort is working as expected");
        }

        [TestMethod]
        public void Comb_Sort_Test()
        {
            var combSort = new Comb_Sort<int>(_inputList);
            Assert.IsTrue(combSort.Sort().SequenceEqual(_sortedList), "Comb sort is working as expected");
        }

        //Scenarios
        [TestMethod]
        public void K_ClosestElements_Test()
        { 
            var tempRef = new List<int>() { 6, 9, 67 };
            var kClosestElements = new K_ClosestElements(_sortedList,23,3);
            Assert.IsTrue(kClosestElements.FindClosest_K().SequenceEqual(tempRef), "K Closest Elements is working as expected");
        }

    }
}
