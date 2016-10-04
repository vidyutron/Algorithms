﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Array_Strings
{
    public class ArrayAndStrings
    {
        public static void UniqueCharCount_1(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                Dictionary<char, int> tempDic = new Dictionary<char, int>();
                bool uniqueCheck = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (tempDic.ContainsKey(word[i]))
                    {
                        tempDic[word[i]]++;
                    }
                    else
                        tempDic.Add(word[i], 1);
                }
                foreach (var item in tempDic)
                {
                    if (item.Value > 1)
                    {
                        uniqueCheck = false;
                        break;
                    }
                }
                if(uniqueCheck)
                    Console.WriteLine($"Given String {word} has unique characters");
                else
                    Console.WriteLine($"Given String {word} has repeating characters");
            }
            else
                Console.WriteLine("Word provided is either empty or null");
        }

        public static void UniqueCharCount_2(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                ConcurrentDictionary<char, int> tempDic = new ConcurrentDictionary<char, int>();
                bool uniqueCheck = true;
                for (int i = 0; i < word.Length; i++)
                {
                    tempDic.AddOrUpdate(word[i], 1, (s, n) => n + 1);
                }
                foreach (var item in tempDic)
                {
                    if (item.Value > 1)
                    {
                        uniqueCheck = false;
                        break;
                    }
                }
                if (uniqueCheck)
                    Console.WriteLine($"Given String {word} has unique characters");
                else
                    Console.WriteLine($"Given String {word} has repeating characters");
            }
        }

        public static void StringPermutation_1(string wordOne,string wordTwo)
        {
            if (!string.IsNullOrEmpty(wordOne) && !string.IsNullOrEmpty(wordTwo))
            {
                if (wordOne.Length != wordTwo.Length) { Console.WriteLine("words are not permutation of each other");}
                else
                {
                    var sortWordOne = new string(Helper.SortArray(wordOne.ToCharArray()));
                    var sortWordTwo =new string(Helper.SortArray(wordTwo.ToCharArray()));
                    if (sortWordOne.Equals(sortWordTwo, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("Words are permutation to each other");
                    else
                    {
                        Console.WriteLine("Words have same lenght, but not permutation to each other");
                    }
                }
            }
            else { Console.WriteLine("Empty string"); }
        }

        public static void StringPermutation_2(string wordOne, string wordTwo)
        {
            if (!string.IsNullOrEmpty(wordOne) && !string.IsNullOrEmpty(wordTwo))
            {
                if (wordOne.Length != wordTwo.Length) { Console.WriteLine("words are not permutation of each other"); }
                else
                {
                    var tempWordOneChar = wordOne.ToCharArray();
                    var tempWordTwoChar = wordTwo.ToCharArray();
                    var sortWordOne = new string(tempWordOneChar);
                    var sortWordTwo = new string(tempWordTwoChar);
                    if (sortWordOne.Equals(sortWordTwo, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("Words are permutation to each other");
                    else
                    {
                        Console.WriteLine("Words have same lenght, but not permutation to each other");
                    }
                }
            }
            else { Console.WriteLine("Empty string"); }
        }


    }
}
