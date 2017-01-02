using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Quick_Sort<T> : ISort<T>
        where T : struct, IComparable
    {
        private int _inputLength;
        private List<T> _inputList;
        private bool _validList;

        public Quick_Sort(List<T> inputList)
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
        private void Swap(ref List<T> argList,int arg1,int arg2)
        {
            var temp = argList[arg1];
            argList[arg1] = argList[arg2];
            argList[arg2] = temp;
        }
        private int Partition(List<T> inputList,int low,int high)
        {
            T pivot = inputList[high];
            int i = low - 1;
            for (int j = low; j < high-1; j++)
            {
                if (inputList[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(ref inputList,i,high);
                }
            }
            Swap(ref inputList, i + 1, high);
            return i + 1;
        }

        public List<T> Sort()
        {
            return Sort(_inputList, 0, _inputLength - 1);
        }

        public List<T> Sort(List<T> inputList,int low, int high)
        {
            if (_validList)
            {
                if(low< high)
                {
                    var pi = Partition(inputList, low, high);
                    Sort(inputList, low, pi - 1);
                    Sort(inputList, pi + 1, high);
                }
                return inputList;
            }
            else
            {
                return null;
            }
        }
    }
}
