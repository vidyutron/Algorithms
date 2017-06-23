using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_Algorithm_Narasimha.Trees.BinaryTrees;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_Test.DS_Algo_Narasimha.Trees.BinaryTree
{
    [TestClass]
    public class BinaryTree
    {
        private BTNode root;
        public BTNode Root { get => root; set => root = value; }

        [TestInitialize]
        public void StartTest()
        {
            var levl2LL = new BTNode(19);
            var levl2LR = new BTNode(22);
            var levl2RL = new BTNode(16);
            var levl2RR = new BTNode(27);


            var lvl1Left = new BTNode(21, levl2LL, levl2LR);
            var lvl2Right = new BTNode(23, levl2RL, levl2RR);

            Root = new BTNode(25, lvl1Left, lvl2Right);
        }



        [TestMethod]
        public void CreateBTAndCheck()
        {
            //var root = new BTNode(25);
            //var lvl1Left = new BTNode(21);
            //var levl1Right = new BTNode(23);
            var levl2LL = new BTNode(19);
            var levl2LR = new BTNode(22);
            var levl2RL = new BTNode(16);
            var levl2RR = new BTNode(27);


            var lvl1Left = new BTNode(21, levl2LL, levl2LR);
            var lvl2Right = new BTNode(23, levl2RL, levl2RR);

            var root = new BTNode(25, lvl1Left, lvl2Right);

            var commonOps = new CommonOpsBT();
            var tempString = commonOps.BTtoString(root);
            Console.WriteLine(commonOps.BTtoString(root));
            Console.ReadKey();

        }

        [TestMethod]
        public void TreeTraversal()
        {
            var levl2LL = new BTNode(19);
            var levl2LR = new BTNode(22);
            var levl2RL = new BTNode(16);
            var levl2RR = new BTNode(27);


            var lvl1Left = new BTNode(21, levl2LL, levl2LR);
            var lvl2Right = new BTNode(23, levl2RL, levl2RR);

            var root = new BTNode(25, lvl1Left, lvl2Right);

            var treeTraversal = new TreeTraversal();

            //PreOrder Test
            //Expected output{25,21,19,22,23,16,27}
            var preOrderList = new List<int> { 25, 21, 19, 22, 23, 16, 27 };
            var compList1 = preOrderList.Except(treeTraversal.PreOrderIte(root)).ToList();
            Assert.AreEqual(compList1.Count(), 0);

            //InOrder Test
            //Expected output{25,21,19,22,23,16,27}
            var inOrderList = new List<int> { 19,21,22,25,23,16,27 };
            var compList2 = inOrderList.Except(treeTraversal.InOrderIte(root)).ToList();
            Assert.AreEqual(compList2.Count(), 0);

            //Post Order Test
            //Expected output{25,21,19,22,23,16,27}
            var postOrderList = new List<int> { 19,22,21,16,27,23,25 };
            var compList3 = postOrderList.Except(treeTraversal.PostOrderIte(root)).ToList();
            //Assert.AreEqual(compList3.Count(), 0);

            //Level Order Test
            //Expected output{25,21,19,22,23,16,27}
            var levelOrderList = new List<int> { 25,21,23,19,22,16,27};
            var compList = levelOrderList.Except(treeTraversal.LevelOrderIte(root)).ToList();
            Assert.AreEqual(compList.Count(), 0);


        }

        [TestMethod]
        public void ReverseLevelOrderTest()
        {
            var testList = new List<int> {19,22,16,27,21,23,25 };
            var reversePractise = new Practise();
            reversePractise.LevelOrderReverse(Root);
            var compList=testList.Except(reversePractise.LevelOrderReverse(root)).ToList();
            Assert.AreEqual(compList, 0);
        }
    }
}
