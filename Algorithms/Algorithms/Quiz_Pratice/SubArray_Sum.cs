using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Quiz_Pratice
{
    public class SubArray_Sum
    {
        private int _inputLength;
        private List<int> _inputList;
        private bool _validList;

        public SubArray_Sum(List<int> inputList)
        {
            if (inputList != null && inputList.Count() > 0)
            {
                _inputList = inputList;
                _validList = true;
                _inputLength = inputList.Count();
            }
        }

        public int Summation()
        {
            if (_validList)
            {
                var temp_list = new List<int>();
                for (int i = 0; i < _inputList.Count(); i++)
                {
                    var temp_subArraySum = 0;
                    for (int k = i; k < _inputList.Count(); k++)
                    {
                        temp_subArraySum += _inputList[k];
                        temp_list.Add(temp_subArraySum);
                    }
                }
                var temp_total = temp_list.Sum(x => Convert.ToInt32(x));
                return temp_total;
            }
            else
            {
                return 0;
            }
        }
    }
}
