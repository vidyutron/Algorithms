using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Comb_Sort<T> : ISort<T> where T : struct, IComparable
    {
        private int _inputLength;
        private List<T> _inputList;

        public Comb_Sort(List<T> inputList)
        {
            _inputList = inputList;
            _inputLength = inputList.Count;
        }

        int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            return gap < 1 ? 1 : gap;
        }
        public List<T> Sort()
        {
            var gap = _inputLength;
            var swapped = true;
            //keep running while gap is more than 1 and last
            //iteration caused a swap
            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);
                //Initialize swapped as false so that we can
                //Check if swap happened or not
                swapped = false;

                //Compare all elements with current gap
                for (int i = 0; i < _inputLength - gap; i++)
                {
                    if (_inputList[i].CompareTo(_inputList[i + gap]) > 0)
                    {
                        T temp = _inputList[i];
                        _inputList[i] = _inputList[i + gap];
                        _inputList[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
            return _inputList;
        }
    }
}
