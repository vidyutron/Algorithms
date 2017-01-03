using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search_Sort
{
    public class Bucket_Sort<T>:ISort<T> where T:struct,IComparable
    {
        private int _bucketCount;
        private List<T> _inputList;

        public Bucket_Sort(List<T> inputList,int bucketCount)
        {
            _inputList = inputList;
            _bucketCount = bucketCount;
        }

        public List<T> Sort()
        {
            var result = new List<T>();
            var buckets = new List<T>[_bucketCount];
            for(int i = 0; i < _bucketCount; i++)
            {
                buckets[i] = new List<T>();
            }
            for(int i = 0; i < _inputList.Count; i++)
            {
                int bucketChoice = Division(_inputList[i] , _bucketCount);
                buckets[bucketChoice].Add(_inputList[i]);
            }
            for(int i = 0; i < _bucketCount; i++)
            {
                var temp = BubbleSortList(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }

        //Bubblesort w/ ListInput
        public static List<T> BubbleSortList(List<T> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].CompareTo(input[j]) < 0)
                    {
                        T temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        static int Division<T>(T a, int b)
        {
            //TODO: re-use delegate!
            // declare the parameters
            ParameterExpression paramA = Expression.Parameter(typeof(T), "a"),
                paramB = Expression.Parameter(typeof(T), "b");
            // add the parameters together
            BinaryExpression body = Expression.Divide(paramA, paramB);
            // compile it
            Func<T, int, int> multiple = Expression.Lambda<Func<T, int, int>>(body, paramA, paramB).Compile();
            // call it
            return multiple(a, b);
        }
    }
}
