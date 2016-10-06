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

        public static char[] StringTrim(char[] word)
        {

            int maxI = 0; // an optimisaiton so it doesn't iterate through chars already encountered
            for (int i = 0; i < word.Length; i++)
            {
                
                if (char.IsWhiteSpace(word[i])) word[i] = '\0';
                else {
                    //maxI = i;
                    break; }
            }

            for (int i = word.Length - 1; i > maxI; i--)
            {
                if (Char.IsWhiteSpace(word[i])) word[i] = '\0';
            }

            return word;
        }
    }
}
