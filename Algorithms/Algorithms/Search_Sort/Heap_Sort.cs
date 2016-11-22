using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Heap_Sort<T>:ISort<T>
        where T:struct,IComparable
    {
        private int _inputLength;
        private List<T> _inputList;
        private bool _validList;

        public Heap_Sort(List<T> inputList)
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

        private void Heapify(List<T> inputList,int n,int root_index)
        {
            var largest = root_index;
            var left = 2 * root_index + 1;
            var right = 2 * root_index + 2;
            try
            {
                if (left < n && inputList[left].CompareTo(inputList[largest]) > 0)
                {
                    largest = left;
                }
                if (right < n && inputList[right].CompareTo(inputList[largest]) > 0)
                {
                    largest = right;
                }
                if (largest != root_index)
                {
                    var temp = inputList[root_index];
                    inputList[root_index] = inputList[largest];
                    inputList[largest] = temp;
                    Heapify(inputList, n, largest);
                }
            }
            catch (Exception)
            {
                
            }
        }

        public List<T> Sort()
        {
            try
            {
                if (_validList)
                {
                    for (int i = _inputLength / 2 - 1; i >= 0; i--)
                    {
                        Heapify(_inputList, _inputLength, i);
                    }
                    for (int k = _inputLength - 1; k >= 0; k--)
                    {
                        var temp = _inputList[k];
                        _inputList[k] = _inputList[0];
                        _inputList[0] = temp;

                        Heapify(_inputList, k, 0);
                    }
                    return _inputList;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            //throw new NotImplementedException();
        }
    }
}
