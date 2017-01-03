using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort.Scenarios
{
    public class K_ClosestElements
    {
        private int _elementCount;
        private int _elementToFind;
        private int _inputLength;
        private List<int> _inputList;

        public K_ClosestElements(List<int> inputList,int elementToFind,
            int elementCount)
        {
            _inputList = inputList;
            _elementToFind = elementToFind;
            _elementCount = elementCount;
            _inputLength = inputList.Count;
        }

        private int FindCrossOver(List<int> inputList,int low,
            int high,int elementToFind)
        {
            //base Cases
            if (inputList[high] <= elementToFind)
                return high;
            if (inputList[low]>elementToFind)
            {
                return low;
            }
            var mid = (low + high) / 2;
            if (inputList[mid]<=elementToFind&& inputList[mid+1]>elementToFind)
            {
                return mid;
            }
            if (inputList[mid] < elementToFind)
                return FindCrossOver(inputList, mid + 1, high, elementToFind);

            return FindCrossOver(inputList, low, mid - 1, elementToFind);
        }

        public List<int> FindClosest_K()
        {
            var tempList = new List<int>();
            var left = FindCrossOver(_inputList, 0, _inputLength - 1, _elementToFind);
            var right = left + 1;
            var count = 0;
            if (_inputList[left] == _elementToFind)
                left--;

            while (left>=0&&right<_inputLength&&count<_elementCount)
            {
                if (_elementToFind - _inputList[left] < _inputList[right] - _elementToFind)
                    tempList.Add(_inputList[left--]);
                else
                    tempList.Add(_inputList[right++]);
            }
            while (count<_elementCount&&left>=0)
            {
                tempList.Add(_inputList[left--]);
                count++;
            }
            while(count<_elementCount&& right < _inputLength)
            {
                tempList.Add(_inputList[right++]);
                count++;
            }
            return tempList;
        }

    }
}
