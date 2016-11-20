using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Bubble_Sort<T>:ISort<T> where T:struct,IComparable<T>
    {
        private int _inputLength;
        private List<T> _inputList;
        private bool _validList;
        public Bubble_Sort(List<T> inputList)
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
            if (_validList)
            {
                var loopLength = _inputLength - 1;
                for(int i = 0; i < loopLength; i++)
                {
                    for (int k = 0; k < loopLength-i; k++)
                    {
                        if (_inputList[k].CompareTo(_inputList[k + 1]) > 0)
                        {
                            var temp = _inputList[k];
                            _inputList[k] = _inputList[k + 1];
                            _inputList[k + 1] = temp;
                        }
                    }
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
