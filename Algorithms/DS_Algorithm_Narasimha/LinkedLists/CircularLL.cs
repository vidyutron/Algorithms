using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class CircularLL
    {
        private int _length;
        private CLLNode _tail;

        public int Length { get { return _length; } set { _length = value; } }

        public CircularLL()
        {
            _tail = null;
            _length = 0;
        }

        public void InsertBegin(int data)
        {
            AddToHead(data);
        }

        public void AddToHead(int data)
        {
            var temp = new CLLNode(data);
            if (_tail == null)
            {
                _tail = temp;
                _tail.Next = _tail;
            }
            else
            {
                temp.Next = _tail.Next;
                _tail.Next = temp;
            }
            _length++;
        }

        public void AddToTail(int data)
        {
            AddToHead(data);
            _tail = _tail.Next;
        }

        public int Peek()
        {
            return _tail.Data;
        }

        public int RemoveFromHead()
        {
            var temp = _tail.Next;
            if (_tail == _tail.Next)
                _tail = null;
            else
            {
                _tail.Next = temp.Next;
                temp.Next = null;
            }
            _length--;
            return temp.Data;
        }

        public int RemoveFromTail()
        {
            if (isEmpty())
                return Int32.MinValue;

            var finger = _tail;
            while (finger.Next != _tail)
                finger = finger.Next;

            var temp = _tail;
            if (finger == _tail) _tail = null;
            else
            {
                finger.Next = _tail.Next;
                _tail = finger;
            }

            _length--;
            return temp.Data;
        }

        public bool Contains(int data)
        {
            if (_tail == null) return false;
            var finger = _tail.Next;
            while(finger!=_tail && (!(finger.Data == data)))
            {
                finger = finger.Next;
            }
            return finger.Data == data;
        }

        public int Remove(int data)
        {
            if (_tail == null) return Int32.MinValue;
            var finger = _tail.Next;
            var previous = _tail;
            for (int compares = 0; compares < _length &&(!(finger.Data==data)); compares++)
            {
                previous = finger;
                finger = finger.Next;
            }
            if (finger.Data == data)
            {
                if (_tail == _tail.Next) _tail = null;
                else
                {
                    if (finger == _tail) _tail = previous;
                    previous.Next = previous.Next.Next;
                }
                finger.Next = null;
                _length--;
                return finger.Data;
            }
            else return Int32.MinValue;
        }

        public string CLLToString()
        {
            var result = "[";
            if (_tail == null) return result + "]";
            result += _tail.Data;
            var temp = _tail.Next;
            while (temp != _tail)
            {
                result += "," + temp.Data;
                temp = temp.Next;
            }

            return result + "]";
        }

        private bool isEmpty()
        {
            return _tail == null;
        }

        public void Clear()
        {
            _length = 0;
            _tail = null;
        }
    }
}
