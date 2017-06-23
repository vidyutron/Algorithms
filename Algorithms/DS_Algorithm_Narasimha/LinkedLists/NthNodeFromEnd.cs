using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    public class NthNodeFromEnd
    {
        private int _counter;
        public ListNode NthNodeFromEndRecursive(ListNode head,int nth)
        {
            if (head != null)
            {
                NthNodeFromEndRecursive(head.Next, nth);
                _counter++;
                if (nth == _counter) return head;
            }
            return null;
        }

        public static ListNode NthNodeFromEndIteractive(ListNode head,int nth)
        {
            if (head == null) return null;
            var nthTemp = head;
            for (int i = 0; i < nth; i++)
            {
                if (nthTemp.Next == null) return null;
                nthTemp = nthTemp.Next;
            }

            while (nthTemp != null)
            {
                head = head.Next;
                nthTemp = nthTemp.Next;
            }
            return head;
        }
    }
}
