using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DS.Trees
{
    public class Heap<T> where T:struct,IComparable
    {
        private List<T> _data = new List<T>();
        public int Count { get { return _data.Count; } }

        public void Insert(T item)
        {
            _data.Add(item);
            int i = _data.Count()-1;
            while (i>0)
            {
                int j = (i + 1) / 2 - 1;
                T v = _data[j];
                if (v.CompareTo(_data[i]) < 0 || v.CompareTo(_data[i]) == 0)
                    break;
                //swapping
                T temp = _data[i];
                _data[i] = _data[j];
                _data[j] = temp;
            }
        }

        public T ExtractMin()
        {
            if (_data.Count < 0)
                throw new ArgumentOutOfRangeException();
            T min = _data[0];
            _data[0] = _data[_data.Count - 1];
            _data.RemoveAt(_data.Count - 1);
            this.MinHeapify(0);
            return min;
        }

        private void MinHeapify(int v)
        {
            int smallest=v;
            int left = (v+1) * 2 + 1;
            int right = (v + 1) * 2 + 2;

            if (_data[left].CompareTo(_data[v]) < 0 && left < _data.Count)
                smallest = left;
            if (_data[right].CompareTo(_data[v]) < 0 && right < _data.Count)
                smallest = right;
            if (smallest != v)
            {
                T temp = _data[smallest];
                _data[v] = _data[smallest];
                _data[smallest] = temp;
                this.MinHeapify(smallest);
            }

        }
    }
}
