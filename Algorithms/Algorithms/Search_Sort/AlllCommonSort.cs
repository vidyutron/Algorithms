using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class AllCommonSort
    {
        private List<int> _sampleData = new List<int> { 56, 12, 34, 67, 45, 2, 8, 6789, 6545, 6789,234,567,435,347,675,126,121,
            81,489,451,6783,5899,890,811,32, 678, 4325, 67895, 4324, 456, 34, 31234, 78, 987, 98, 88, 45,678,56,459,211,234,238,290,341,367,3567,387,412,410,4346,476,489,498 };
        private Dictionary<string,double> _counter=new Dictionary<string, double>();
        public void BubbelSort()
        {
            var localData = _sampleData;
            var stpWatch = new Stopwatch();
            stpWatch.Start();
            for (int i = 0; i <= localData.Count(); i++)
            {
                for (int j = i+1; j < localData.Count(); j++)
                {
                    if (localData[i] > localData[j])
                    {
                        var temp = localData[i];
                        localData[i] = localData[j];
                        localData[j] = temp;
                    }
                }
            }
            stpWatch.Stop();
            _counter.Add("Bubble Sort",stpWatch.Elapsed.TotalMilliseconds);
        }

        public void SelectionSort()
        {
            var localData = _sampleData;
            int min;
            var stpWatch = new Stopwatch();
            stpWatch.Start();
            for (int i = 0; i < localData.Count(); i++)
            {
                min = i;
                for (int j = i+1; j < localData.Count(); j++)
                {
                    if (localData[j] < localData[min])
                        min = j;
                }
                var temp = localData[min];
                localData[min] = localData[i];
                localData[i] = temp;
            }
            stpWatch.Stop();
            _counter.Add("SelectionSort",stpWatch.Elapsed.TotalMilliseconds);
        }

        public void InsertionSort()
        {
            var localData = _sampleData;
            var stpWatch = new Stopwatch();
            stpWatch.Start();
            for (int i = 1; i < localData.Count(); i++)
            {
                var j = i;
                var temp = localData[i];
                while (localData[j-1]>temp&&j>=1)
                {
                    localData[j] = localData[j - 1];
                    j--;
                }
                localData[j] = temp;
            }
            stpWatch.Stop();
            _counter.Add("Insertion Sort",stpWatch.Elapsed.TotalMilliseconds);
        }

        public static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low +high)/ 2;
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        public void MergeSort()
        {
            var input = _sampleData.ToArray();
            var stpWatch = new Stopwatch();
            stpWatch.Start();
            MergeSort(input, 0, input.Length - 1);
            stpWatch.Stop();
            _counter.Add("Merge Sort",stpWatch.Elapsed.TotalMilliseconds);
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

        }


        public void QuickSort()
        {
            var stpWatch = new Stopwatch();
            stpWatch.Start();
            var a = _sampleData.ToArray();
            QuickSort( ref a, 0, a.Length - 1);
            stpWatch.Stop();
            _counter.Add("Quick Sort",stpWatch.Elapsed.TotalMilliseconds);
        }

        private void QuickSort(ref int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i]<pivot)
                {
                    i++;
                }

                while (elements[j]>pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort( ref elements, left, j);
            }

            if (i < right)
            {
                QuickSort( ref elements, i, right);
            }
        }

        public void FinalSummary()
        {
           var temp= _counter;
        }
    }
}
