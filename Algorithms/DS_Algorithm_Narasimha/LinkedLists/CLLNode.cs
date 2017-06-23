using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class CLLNode
    {
        private int _data;
        private CLLNode _next;

        public int Data { get { return _data; } set { _data = value; } }
        public CLLNode Next { get { return _next; } set { _next = value; } }

        public CLLNode()
        {
            _next = null;
            _data = int.MinValue;

        }

        public CLLNode(int data)
        {
            _next = null;
            _data = data;
        }

        public string toString()
        {
            return _data.ToString();
        }
    }
}
