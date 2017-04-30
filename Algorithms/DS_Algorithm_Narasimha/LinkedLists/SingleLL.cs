using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class SingleLL
    {
        private int _length;

        public SingleLL(int length)
        {
            _length = length;
        }

        public ListNode Head { get; private set; }

        public ListNode GetHead()
        {
            return Head;
        }

        public void InsertAtBegin(ListNode node)
        {
            node.Next=Head;
            Head = node;
            _length++;
        }
        
        public void InsertAtEnd(ListNode node)
        {
            if (Head == null) Head = node;
            else
            {
                ListNode tempOne,tempTwo;
                for (tempOne = Head; (tempTwo = tempOne.Next) != null; tempOne = tempTwo) ;
                    tempOne.Next = node;           
            }
            _length++;
        }

        public void Insert(int data,int position)
        {
            if (position < 0)
                position = 0;
            if (position > _length)
                position = _length;

            if (Head==null)
            {
                Head = new ListNode(data);
            }
            else if (position == 0)
            {
                var temp = new ListNode(data);
                temp.Next = Head;
                Head = temp;
            }
            else
            {
                var temp = Head;
                for (int i = 1; i < position; i++)
                {
                    temp = temp.Next;
                }
                var newNode = new ListNode(data);
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            _length++;
        }

        public ListNode RemoveFromBegin()
        {
            var node = Head;
            if (node != null)
            {
                Head = node.Next;
                node.Next = null;
            }
            return node;
        }

        public ListNode GetLast()
        {
            if (Head==null)
            {
                return null;
            }
            if (Head.Next == null)
                return Head;
            var tempOne = Head.Next;
            while (tempOne.Next != null)
                tempOne = tempOne.Next;

            return tempOne;
        }

        public ListNode RemoveFromEnd()
        {
            if (Head == null)
                return null;
            ListNode p = Head, q = null, next = Head.Next;
            if (next == null)
            {
                Head = null;
                _length--;
                return p;
            }
            while ((next = p.Next) != null)
            {
                q = p;
                p = next;
            }

            q.Next = null;
            _length--;
            return p;
        }

        public void RemoveMatched(ListNode node)
        {
            if (Head == null)
                return;
            if (node.Equals(Head))
            {
                Head = Head.Next;
                _length--;
                return;
            }
            ListNode p = Head, q = null;
            while ((q = p.Next) != null)
            {
                if (node.Equals(q))
                {
                    p.Next = q.Next;
                    _length--;
                    return;
                }
                p = q;
            }
        }

        public void Remove(int position)
        {
            if (position < 0)
                position = 0;
            if (position >= _length)
                position = _length--;

            if (Head == null)
                return;

            if (position == 0)
            {
                Head = Head.Next;
            }
            else
            {
                var temp = Head;
                for (int i = 1; i < position; i++)
                {
                    temp = temp.Next;
                }
                temp.Next = temp.Next.Next;

            }
            _length--;
        }
        public int length()
        {
            return _length;
        }

        public int GetPosition(int data)
        {
            var temp = Head;
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

        public string LinkedListToString()
        {
            var llString = new StringBuilder();
            llString.Append("[ ");
            if(Head==null)
            {
                llString.Append("]");
                return llString.ToString();
            }
            llString = llString.Append(Head.Data);
            var temp = Head.Next;
            while (temp != null)
            {
                llString.Append("," + temp.Data);
                temp = temp.Next;
            }
            return llString.Append(" ]").ToString();
        }

        public Boolean IsEmpty()
        {
            return _length == 0;
        }

        public void ClearList()
        {
            Head = null;
            _length = 0;
        }
    }
}
