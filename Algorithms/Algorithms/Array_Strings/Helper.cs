using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Array_Strings
{
    public class Helper
    {
        public static char[] SortArray(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i; j < word.Length; j++)
                {
                    if ((int)word[j] < (int)word[i])
                    {
                        char tempChar = word[i];
                        word[i] = word[j];
                        word[j] = tempChar;
                    }
                }
            }
            return word;
        }
    }
}
