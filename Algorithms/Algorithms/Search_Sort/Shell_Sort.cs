using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Shell_Sort<T>:ISort<T> where T:struct,IComparable
    {
        private int _inputLength;
        private List<T> _inputList;

        public Shell_Sort(List<T> inputList)
        {
            _inputList = inputList;
            _inputLength = inputList.Count;
        }

        public List<T> Sort()
        {
            for (int gap = _inputLength/2; gap>0; gap/=2)
            {
                for (int i = gap; i < _inputLength; i++)
                {
                    T temp = _inputList[i];
                    int j;
                    for (j = i; j >= gap&& _inputList[j-gap].CompareTo(temp)>0; j-=gap)
                    {
                        _inputList[j] = _inputList[j - gap];
                    }
                    _inputList[j] = temp;
                }
            }
            return _inputList;
        }
    }
}
