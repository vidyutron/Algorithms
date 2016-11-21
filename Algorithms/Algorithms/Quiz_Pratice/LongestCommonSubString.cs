using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Quiz_Pratice
{
    public class LongestCommonSubString
    {
        private string _inputOne;
        private string _inputTwo;
        private bool _validStrings;

        public LongestCommonSubString(string inputOne,string inputTwo)
        {
            if (!string.IsNullOrEmpty(inputOne) && !string.IsNullOrEmpty(inputTwo))
            {
                _inputOne = inputOne;
                _inputTwo = inputTwo;
                _validStrings = true;
            }
            else
            {
                _validStrings = false;
            }
        }

        public LCS SubStringMatch()
        {
            if (_validStrings)
            {
                var temp_listOne = _inputOne.Select(c => c.ToString()).ToList();
                var temp_listTwo = _inputTwo.Select(c => c.ToString()).ToList();
                var temp_dictOne = Listification(temp_listOne);
                var temp_dictTwo = Listification(temp_listTwo);
                var temp_minCount = temp_dictOne.Count() <= temp_dictTwo.Count() ? temp_dictOne.Count() : temp_dictTwo.Count();
                var temp_matchingSubStringList = temp_dictOne.Intersect(temp_dictTwo);

                return new LCS
                {
                    MatchingSubString = temp_matchingSubStringList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur),
                    SubstringLength = temp_matchingSubStringList.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length
                };
            }
            else
            {
                return null;
            }
        }

        private List<string> Listification(List<string> inputList)
        {
            var temp_dict = new List<string>();
            for (int i = 0; i < inputList.Count(); i++)
            {
                var temp_string = string.Empty;
                for (int k = i; k < inputList.Count(); k++)
                {
                    temp_string += inputList[k];
                    temp_dict.Add(temp_string);
                }
            }
            return temp_dict;
        }


    }

    public class LCS
    {
        public string MatchingSubString { get; set; }
        public int SubstringLength { get; set; }
    }
}
