using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Merge_Sort<T>:ISort<T>
        where T:struct,IComparable
    {
        private int _inputLength;
        private List<T> _inputList;
        private bool _validList;

        public Merge_Sort(List<T> inputList)
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

        private void Merge(List<T> inputList,int left,int middle, int right)
        {
            var temp_n1 = middle - left + 1;
            var temp_n2 = right - middle;
            var temp_ListOne = new List<T>();
            var temp_ListTwo=new List<T>();
            for (int i = 0; i < temp_n1; i++)
            {
                temp_ListOne[i] = inputList[left + 1];
            }
            for (int k = 0; k < temp_n2; k++)
            {
                temp_ListTwo[k] = inputList[middle + 1 + k];
            }
            var index_tempListOne = 0;
            var index_tempListTwo = 0;
            var index_mergedList = left;

            while (index_tempListOne<temp_n1&&
                index_tempListTwo<temp_n2)
            {
                if (temp_ListOne[index_tempListOne].CompareTo(temp_ListTwo[index_tempListTwo]) < 0)
                {
                    inputList[index_mergedList] = temp_ListOne[index_tempListOne];
                    index_tempListOne++;
                }
                else
                {
                    inputList[index_mergedList] = temp_ListTwo[index_tempListTwo];
                    index_tempListTwo++;
                }
            }

            while (index_tempListOne<temp_n1)
            {
                inputList[index_mergedList] = temp_ListOne[index_tempListOne];
                index_tempListOne++;
                index_mergedList++;
            }

            while (index_tempListTwo < temp_n2)
            {
                inputList[index_tempListTwo] = temp_ListTwo[index_tempListTwo];
                index_tempListTwo++;
                index_mergedList++;
            }
        }

        public void Sort(List<T> inputList,int left,int right)
        {
            //throw new NotImplementedException();
            if (_validList)
            {
                if (left < right)
                {
                    int middle = left + (right - left) / 2;
                    Sort(inputList, left, middle);
                    Sort(inputList, middle + 1, right);
                    Merge(inputList, left, middle, right);
                }
            }
           
        }

        public List<T> Sort()
        {
            //throw new NotImplementedException();
            this.Sort(_inputList, 0, _inputLength - 1);
            return _inputList;
        }
    }
}
