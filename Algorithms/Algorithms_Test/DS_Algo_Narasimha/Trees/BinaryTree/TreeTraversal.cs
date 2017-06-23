using DS_Algorithm_Narasimha.Trees.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Test.DS_Algo_Narasimha.Trees.BinaryTree
{
    public class TreeTraversal
    {
        public List<int> PreOrderIte(BTNode root)
        {
            var tempList = new List<int>();
            if (root == null) return tempList;

            var tempS = new Stack<BTNode>();
            tempS.Push(root);

            while (tempS.Count != 0)
            {
                var tempNode = tempS.Pop();
                tempList.Add(tempNode.Data);
                if (tempNode.Right != null) tempS.Push(tempNode.Right);
                if (tempNode.Left != null) tempS.Push(tempNode.Left);
                

            }

            return tempList;
        }

        public List<int> InOrderIte(BTNode root)
        {
            var tempList = new List<int>();
            if (root == null) return tempList;

            var tempS = new Stack<BTNode>();
            var tempNode = root;
            var done = false;
            while (!done)
            {
                if (tempNode != null)
                {
                    tempS.Push(tempNode);
                    tempNode = tempNode.Left;
                }
                else
                {
                    if (tempS.Count == 0) done = true;
                    else
                    {
                        tempNode = tempS.Pop();
                        tempList.Add(tempNode.Data);
                        tempNode = tempNode.Right;
                    }
                }
            }

            return tempList;
        }


        public List<int> PostOrderIte(BTNode root)
        {
            var tempList = new List<int>();
            if (root == null) return tempList;

            BTNode tempNode = null;
            var tempS = new Stack<BTNode>();
            tempS.Push(root);

            while (tempS.Count != 0)
            {
                var curr = tempS.Peek();
                if (tempNode == null || tempNode.Left == curr || tempNode.Right == curr)
                {
                    if (curr.Left != null) tempS.Push(curr.Left);
                    if (curr.Right != null) tempS.Push(curr.Right);
                }
                else if(curr.Left==tempNode)
                {
                    if (curr.Right != null) tempS.Push(curr.Right);
                }
                else
                {
                    tempList.Add(curr.Data);
                    tempS.Pop();
                }
                tempNode = curr;
            }
            return tempList;
        }

        public List<int> LevelOrderIte(BTNode root)
        {
            var tempList = new List<int>();
            if (root == null) return tempList;

            var tempQ = new Queue<BTNode>();
            var tempNode = root;
            tempQ.Enqueue(root);
            while (tempQ.Count != 0)
            {
                tempNode = tempQ.Dequeue();
                tempList.Add(tempNode.Data);

                if (tempNode.Left != null) tempQ.Enqueue(tempNode.Left);
                if (tempNode.Right != null) tempQ.Enqueue(tempNode.Right);
            }

            return tempList;
        }
    }
}
