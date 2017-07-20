using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo_Narasimha.Strings
{
    public class Palindrome
    {
        private string _str;

        public Palindrome(string str)
        {
            _str = str;
        }

        //Time Complexity O(n^2) space complexity O(1)
        public string LongestPalindromeSubString()
        {
            var tempString = string.Empty;
            var len = 0;
            var start = 0; var maxLen = 0; var low = 0; var high = 0;
            if (_str.Length > 0) len = _str.Length;
            for (int i = 1; i < len; i++)
            {
                //for even lengthed pattern
                low = i - 1;
                high = i;
                while (low >= 0 && high < len && _str[low] == _str[high])
                {
                    if (high - low + 1 > maxLen)
                    {
                        start = low;
                        maxLen = high - low + 1;
                    }
                    --low;
                    ++high;
                }

                //for odd lengthed pattern
                low = i - 1;
                high = i + 1;
                while (low >= 0 && high < len && _str[low] == _str[high])
                {
                    if (high - low + 1 > maxLen)
                    {
                        start = low;
                        maxLen = high - low + 2;
                    }
                    --low;
                    ++high;
                }

            }
            var some = new int[5,6];
            


            return _str.Substring(start, maxLen);
        }
    }
}
