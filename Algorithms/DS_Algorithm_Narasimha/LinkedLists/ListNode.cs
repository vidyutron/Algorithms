using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class ListNode
    {
        private int _data;
        private ListNode _next;

        public int Data { get { return _data; } set { _data = value; } }
        public ListNode Next { get { return _next; } set { _next = value; } }

        public ListNode(int data)
        {
            _data = data;
        }
    }
}
