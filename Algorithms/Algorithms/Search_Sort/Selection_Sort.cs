using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Selection_Sort<T>:ISort<T> where T:struct,IComparable
    {
        private int _inputLength;
        private List<T> _inputList;
        private bool _validList;

        public Selection_Sort(List<T> inputList)
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
                //var sortedList = new List<T>();
                var inputLength = _inputList.Count();
                int swap_position;

                for (int i = 0; i < _inputLength-1; i++)
                {
                    swap_position = i;
                    var temp = _inputList[i];
                    for (int k = i+1; k < _inputLength; k++)
                    {
                        if (_inputList[k].CompareTo(temp) < 0)
                        {
                            temp = _inputList[k];
                            swap_position = k;
                        }
                    }
                    if (swap_position.CompareTo(i) != 0)
                    {
                        _inputList[swap_position] = _inputList[i];
                        _inputList[i] = temp;
                    }
                }
                return _inputList;
            }
            else
                return null;
        }

    }
}
