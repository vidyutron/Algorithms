﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_Algorithm_Narasimha.LinkedLists;

namespace Algorithms_Test.DS_Algo_Narasimha.LinkedLists
{
    [TestClass]
    public class LinkedListTest
    {
        
        [TestInitialize]
        public void LoadData()
        {

        }

        [TestMethod]
        public void SingleLinkedList()
        {
            var listNode = new ListNode(23);
            var sLinkedList = new SingleLL(3);
            sLinkedList.InsertAtBegin(listNode);
            sLinkedList.InsertAtBegin(new ListNode(45));
            sLinkedList.InsertAtBegin(new ListNode(55));

            var outputBeginTest= sLinkedList.LinkedListToString();
            Assert.AreEqual(outputBeginTest, "[ 55,45,23 ]", true);

            sLinkedList.InsertAtEnd(new ListNode(45));
            var outputEndTest = sLinkedList.LinkedListToString();
            Assert.AreEqual(outputEndTest, "[ 55,45,23,45 ]");

            sLinkedList.Insert(67, 3);
            var outputMiddleTest = sLinkedList.LinkedListToString();
            Assert.AreEqual(outputMiddleTest, "[ 55,45,23,67,45 ]");

            sLinkedList.RemoveFromBegin();
            var outputDeleteBegin = sLinkedList.LinkedListToString();
            Assert.AreEqual(outputDeleteBegin, "[ 45,23,67,45 ]");

            sLinkedList.RemoveFromEnd();
            var outputDeleteEnd = sLinkedList.LinkedListToString();
            Assert.AreEqual(outputDeleteEnd, "[ 45,23,67 ]");

            sLinkedList.Remove(2);
            var outputDeleteMiddle = sLinkedList.LinkedListToString();
            Assert.AreEqual(outputDeleteMiddle, "[ 45,23 ]");
            //Console.ReadKey();

        }
        [TestMethod]
        public void DoubleLinkedList()
        {
            //var dllNode = new DLLNode(25);
            var dllList = new DoubleLL();
            dllList.InsertBegin(34);
            dllList.InsertTail(45);
            dllList.InsertTail(67);

            var outputInsert = dllList.DLLToString();
            Assert.AreEqual(outputInsert, "[ 34,45,67 ]");
        }

        [TestMethod]
        public void SkipListLinkedList()
        {
            //var skipLL = new SkipListLL<Int32,int>();
            //skipLL.Add
        }
    }
}
