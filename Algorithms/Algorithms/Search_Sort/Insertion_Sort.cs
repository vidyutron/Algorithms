using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Insertion_Sort<T>:ISort<T>
        where T:struct,IComparable
    {
        private int _inputLength;
        private List<T> _inputList;
        private bool _validList;

        public Insertion_Sort(List<T> inputList)
        {
            if (inputList != null && inputList.Count() > 0)
            {
                _validList = true;
                _inputList = inputList;
                _inputLength = inputList.Count();
            }
            else
                _validList = false;
        }

        public List<T> Sort()
        {
            //throw new NotImplementedException();
            if (_validList)
            {
                for (int i = 1; i < _inputLength; i++)
                {
                    var key = _inputList[i];
                    var j = i - 1;
                    while (j>=0 && _inputList[j].CompareTo(key)>0)
                    {
                        _inputList[j + 1] = _inputList[j];
                        j--;
                    }
                    _inputList[j + 1] = key;
                }
                return _inputList;
            }
            else
            {
                return null;
            }

        }
    }
}
