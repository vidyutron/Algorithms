using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Quiz_Practice
{
    public class Anagrams
    {
        private string _item;
        private List<string> _list;

        public Anagrams(List<string> list)
        {
            _list = list;
        }
        public Anagrams(string item)
        {
            _item = item;
        }

        public bool CheckAnagram()
        {
            if (_list.Count == 0) return false;
            var tempList = new List<string>();
            foreach(var item in _list)
            {
                tempList.Add(new string(item.OrderBy(c => c).ToArray()));
            }
            for (int i = 0; i < _list.Count; i++)
            {
                if (tempList[i] == tempList[i + 1])
                    return true;
            }
            return false;
        }

        public int AsciiSum(char[] str) {
            var sum = 0;
            foreach (var item in str)
                sum += (int)item;
            return sum;
        }


        public int somefun(int a)
        {
            return 0;
        }

        public bool somefun(bool a)
        {
            return false;
      
        }

      
    }

    public class A
    {
        public int MyProperty { get; set; }
    }

    public class B : A
    {
        public int MyProperty { get; set; }

       
    }
}
