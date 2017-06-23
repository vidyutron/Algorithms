using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.Trees.BinaryTrees
{
    public class BTNode
    {
        private int _data;
        private BTNode _left;
        private BTNode _right;

        public BTNode Left { get{ return _left; } set { _left = value; } }
        public BTNode Right { get { return _right; } set { _right = value; } }
        public int Data { get { return _data; } set { _data = value; } }

        public BTNode(int data)
        {
            _data = data;
            _left = null;
            _right = null;
        }

        public BTNode(int data,BTNode left, BTNode right)
        {
            _data = data;
            _left = left;
            _right = right;
        }

        public bool IsLeaf() { return _left == null && _right == null; }
    }
}
