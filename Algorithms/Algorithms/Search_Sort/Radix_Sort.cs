using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Radix_Sort
    {
        private List<int> _inputList;
        private IList<IList<int>> _tempList = new List<IList<int>>();
        private int _length;

        public Radix_Sort(List<int> inputList,int length)
        {
            _inputList = inputList;
            _length = length;
            for (int i = 0; i < 10; i++)
            {
                _tempList.Add(new List<int>());
            }
        }

        public List<int> Sort()
        {
            for(int i = 0; i < _length; i++)
            {
                for(int j = 0; j < _inputList.Count; j++)
                {
                    var digit=(int)((_inputList[j]%Math.Pow(10,i+1))/Math.Pow(10,i));
                    _tempList[digit].Add(_inputList[j]);
                }
                var index = 0;
                for(int k = 0; k < _tempList.Count; k++)
                {
                    var tempList = _tempList[k];
                    for(int l = 0; l < tempList.Count; l++)
                    {
                        _inputList[index++] = tempList[l];
                    }
                }
                ClearCollection();
            }
            return _inputList;
        }

        private void ClearCollection()
        {
            for (int k = 0; k < _tempList.Count; k++)
            {
                _tempList[k].Clear();
            }
        }
    }
}
