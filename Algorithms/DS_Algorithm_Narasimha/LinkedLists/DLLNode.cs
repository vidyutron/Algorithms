using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class DLLNode
    {
        private int _data;
        private DLLNode _next;
        private DLLNode _prev;

        public DLLNode Prev { get { return _prev; } set { _prev = value; } }
        public DLLNode Next { get { return _next; } set { _next = value; } }

        public int Data { get { return _data; } set { _data = value; } }
        public DLLNode(int data,DLLNode prev,DLLNode next)
        {
            _data = data;
            _prev = prev;
            _next = next;
        }

        public DLLNode(int data)
        {
            _data = data;
            _next = null;
            _prev = null;
        }

    }
}
