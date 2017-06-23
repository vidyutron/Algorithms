using DS_Algorithm_Narasimha.Trees.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Test.DS_Algo_Narasimha.Trees.BinaryTree
{
    public class Practise
    {
        //give an algorithm to print the level order data in reverse
        //i/p-1234567-->4567231

        public List<int> LevelOrderReverse(BTNode root)
        {
            var tempStack = new Stack<BTNode>();
            var tempList = new List<int>();
            if (root == null) return tempList;

            
            var tempQ = new Queue<BTNode>();
            tempQ.Enqueue(root);
            while (tempQ.Count != 0)
            {
                var tempNode = tempQ.Dequeue();
                tempStack.Push(tempNode);

                if (tempNode.Right != null) tempQ.Enqueue(tempNode.Right);
                if (tempNode.Left != null) tempQ.Enqueue(tempNode.Left);
            }
            foreach (var item in tempStack)
                tempList.Add(item.Data);
            return tempList; 
        }
    }
}
