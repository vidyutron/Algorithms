using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class DoubleLL
    {
        private DLLNode _head;
        private int _length;
        private DLLNode _tail;

        public int Length { get { return _length; } set { _length = value; } }

        public DoubleLL()
        {
            _head = new DLLNode(Int32.MinValue, null, null);
            _tail = new DLLNode(Int32.MinValue, _head, null);
            _head.Next = _tail;
            _length = 0;
        }

        public int GetPosition(int data)
        {
            var temp = _head;
            var pos = 0;
            while (temp != null)
            {
                if (temp.Data == data)
                    return pos;
                pos++;
                temp = temp.Next;
            }

            return Int32.MinValue;
        }

        public int Get(int position)
        {
            return Int32.MinValue;
        }

        public void InsertBegin(int value)
        {
            var newNode = new DLLNode(value, null, _head.Next);
            newNode.Next.Prev = newNode;
            _head = newNode;
            _length++;
        }

        public void Insert(int data,int position)
        {
            if(position<0) position= 0;
            if (position > _length) position = _length;

            if (_head == null)
            {
                _head = new DLLNode(data);
                _tail = _head;
            }
            else if (position == 0)
            {
                var temp = new DLLNode(data);
                temp.Next = _head;
                _head = temp;
            }
            else
            {
                var temp = _head;
                for (int i = 1; i < position; i++)
                    temp = temp.Next;
                var newNode = new DLLNode(data);
                newNode.Next = temp.Next;
                newNode.Prev = temp;
                newNode.Next.Prev = newNode;
                temp.Next = newNode;
            }
            _length++;
        }

        public void InsertTail(int value)
        {
            var newNode = new DLLNode(value, _tail.Prev, _tail);
            newNode.Prev.Next = newNode;
            _tail.Prev = newNode;
            _length++;
        } 

        public void Remove(int position)
        {
            if (position < 0) position = 0;
            if (position >= _length) _length--;

            if (_head == null) return;

            if (position == 0)
            {
                _head = _head.Next;
                if (_head == null)
                    _tail = null;
            }
            else
            {
                var temp = _head;
                for (int i = 1; i < position; i++) temp = temp.Next;
                temp.Next.Prev = temp.Prev;
                temp.Prev.Next = temp.Next;
            }
            _length--;
        }

            public void RemoveMatched(DLLNode node)
        {
            if (_head == null) return;
            if (node.Equals(_head))
            {
                _head = _head.Next;
                if (_head == null)
                    _tail = null;
                return;
            }
            var p = _head;
            while (p != null)
            {
                if (node.Equals(p))
                {
                    p.Prev.Next = p.Next;
                    p.Next.Prev = p.Prev;
                    return;
                }
            }
        }

        public int RemoveHead()
        {
            if (_length == 0) return Int32.MinValue;
            var save = _head.Next;
            _head.Next = save.Next;
            save.Next.Prev = _head;
            _length--;
            return save.Data;
        }

        public int RemoveTail()
        {
            if (_length == 0) return Int32.MinValue;
            var save = _tail.Prev;
            _tail.Prev = save.Prev;
            save.Prev.Next = _tail;
            _length--;
            return save.Data;
        }

        public string DLLToString()
        {
            var result = "[ ]";
            if (_length == 0)
                return result;
            result = "[ " + _head.Data;
            var temp = _head.Next;
            while (temp != _tail)
            {
                result += "," + temp.Data;
                temp = temp.Next;
            }
            return result + " ]";
        }

        public void ClearList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }
    }
}
