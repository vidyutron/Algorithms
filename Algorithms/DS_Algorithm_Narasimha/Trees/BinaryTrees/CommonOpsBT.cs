using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.Trees.BinaryTrees
{
    public class CommonOpsBT
    {
        public static bool FindInBT(BTNode root,int data)
        {
            if (root==null)
            {
                return false;
            }
            if (root.Data==data)
            {
                return true;
            }

            return FindInBT(root.Left, data) || FindInBT(root.Right, data);
        }

        public int NumberOfNodes(BTNode root)
        {
            var leftCount = root.Left == null ? 0 : NumberOfNodes(root.Left);
            var rightCount = root.Right == null ? 0 : NumberOfNodes(root.Right);
            return 1 + leftCount + rightCount;
        }

        public void ReverseInPlace(BTNode root)
        {
            if (root.Left != null) ReverseInPlace(root.Left);
            if (root.Right != null) ReverseInPlace(root.Right);
            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;
        }

        //right child becomes left and vice versa
        public BTNode Reverse(BTNode root)
        {
            BTNode left = null, right = null;
            if (root.Left!=null)
            {
                left = Reverse(root.Left);
            }
            if (root.Right != null) 
            {
                right = Reverse(root.Right);
            }

            return new BTNode(root.Data, right, left);
        }

        public string BTtoString(BTNode root)
        {
            if (root.IsLeaf()) return root.Data.ToString();
            else
            {
                string start, left="null", right = "null";
                start = root.Data.ToString();
                if (root.Left!=null)
                {
                    left = root.Left.Data.ToString();
                }
                if (root.Right!=null)
                {
                    right = root.Right.Data.ToString();
                }

                return start + " (" + left + ", " + right + ")";
            }

        }
    }
}
