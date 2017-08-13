using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DS.Trees
{
    public class CommonOperations
    {
        private List<int> _sampleData = new List<int> { 56, 12, 34, 67, 45, 2, 8, 6789, 6545, 6789,234,567,435,347,675,126,121,
            81,489,451,6783,5899,890,811,32, 678, 4325, 67895, 4324, 456, 34, 31234, 78, 987, 98, 88, 45,678,56,459,211,234,238,290,341,367,3567,387,412,410,4346,476,489,498 };
        private Dictionary<string, double> _counter = new Dictionary<string, double>();

        public void CreateBST()
        {
            List<int> localData = _sampleData.OrderBy(x=>x).ToList();
            var temp=CreateBST(localData,0,localData.Count()-1);
            var tempList = InOrderTraversal(temp);
        }
        public BSTNode CreateBST(List<int> localData,int start,int end)
        {
            if (end > start)
            {
                int mid = (start + end) / 2;
                var newNode = new BSTNode()
                {
                    Left = CreateBST(localData, start, mid - 1),
                    Right = CreateBST(localData, mid + 1, end),
                    Value = localData[mid]
                };
                return newNode;
            }
            else return null;
            }
        public List<int> InOrderTraversal(BSTNode root)
        {
            if (root != null)
            {
                var tempNode = root;
                var tempStack = new Stack<BSTNode>();
                var tempList = new List<int>();
                var done = false;
                while (!done)
                {
                    if (tempNode != null)
                    {
                        tempStack.Push(tempNode);
                        tempNode = tempNode.Left;
                    }
                    else if (tempStack.Count == 0)
                        done = true;
                    else
                    {
                        tempNode = tempStack.Pop();
                        tempList.Add(tempNode.Value);
                        tempNode = tempNode.Right;
                    }
                }
                return tempList;
            }
            else
            {
                return null;
            }
        }


    }

    

    public class BSTNode
    {
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
        public int Value { get; set; }
        public void SetRight(int i)
        {

        }
        public void SetLeft(int i)
        {

        }
    }
}
