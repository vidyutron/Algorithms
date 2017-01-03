using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Pigeonhole_Sort<T>:ISort<T> where T:struct,IComparable
    {
        private int _inputLength;
        private List<T> _inputList;

        public Pigeonhole_Sort(List<T> inputList)
        {
            _inputList = inputList;
            _inputLength = inputList.Count;
        }

        public List<T> Sort()
        {
            T min = _inputList[0], max = _inputList[0];
            for (int i = 1; i < _inputLength; i++)
            {
                if (_inputList[i].CompareTo(min)<0)
                {
                    min = _inputList[i];
                }
                if (_inputList[i].CompareTo(max) > 0)
                    max = _inputList[i];
            }

            throw new NotImplementedException();
        }
    }
}
