using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.DS
{
    public class TwodArray
    {
        public TwodArray(int[,] arr)
        {
            var maxArray = 0;
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                for (int arr_k = 0; arr_k < 6; arr_k++)
                {
                    if (arr_i < 4 && arr_k < 4)
                    {
                        int tempArray = 0;
                        for (int i = arr_i; i < arr_i + 3; i++)
                        {
                            
                            for (int k = arr_k; k < arr_k + 3; k++)
                            {
                                //skip (1,0) and (1,2)
                                if (i == arr_i+1 && k == arr_k) continue;
                                if (i == arr_i+1 && k == arr_k+2) continue;
                                tempArray += arr[i,k];
                                
                            }
                            maxArray = maxArray > tempArray ? maxArray : tempArray;
                            
                        }
                    }
                }
            }
            Console.WriteLine(maxArray);
        }
    }
}
