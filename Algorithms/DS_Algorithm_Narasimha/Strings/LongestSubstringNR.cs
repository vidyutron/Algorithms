using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.Strings
{
    public class LongestSubstringNR
    {
        private string _str;
        const int CHARS= 256;

        public LongestSubstringNR(string str)
        {
            _str = str;
        }

        public string LongestNonRepeatingSubstring()
        {
            if (_str.Length > 0)
            {
                int start_index = 0;
                int cur_len = 1;
                int max_len = 1;
                int prev_index = 1;

                var visited = new int[CHARS];
                for (int i = 0; i < CHARS; i++) visited[i] = -1;

                //mark first character as visted from the char array
                visited[_str[0]] = 0;

                for (int i = 1; i < _str.Length; i++)
                {
                    prev_index = visited[_str[i]];

                    if (prev_index == -1 || i - cur_len > prev_index)
                        cur_len++;
                    else
                    {
                        if (cur_len > max_len) { max_len = cur_len; start_index = i-max_len+1; }
                        cur_len = i - prev_index;

                    }
                    visited[_str[i]] = i;

                    if (cur_len > max_len) { max_len = cur_len; start_index = i-max_len+1; }
                }
                return _str.Substring(start_index, max_len);

            }
            return string.Empty;
        }
    }
}
