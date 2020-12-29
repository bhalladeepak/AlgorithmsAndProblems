using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public static class CheckSubString
    {
        /*
         *Check if a string is substring of another : Given two strings s1 and s2, find if s1 is a substring of s2. If yes, return the index of the first occurrence, else return -1.
         *https://www.geeksforgeeks.org/check-string-substring-another/
         */
        public static void PrintSubStringIndex()
        {
            Console.WriteLine($"Check if a string is substring of another");
            string mainStr = "geeksforgeeks";
            string subStr = "for";

            int index = SubStringFirstIndex(mainStr, subStr);

            Console.WriteLine($"Main string : {mainStr}");
            Console.WriteLine($"SubString : {subStr}");
            Console.WriteLine($"Index of SubString : {index}");

        }

        private static int SubStringFirstIndex(string s1, string s2)
        {
            int index = -1;
            int s1Len = s1.Length;
            int s2Len = s2.Length;
            for (int i = 0; i < s1Len - s2Len; i++)
            {
                int j;
                for (j = 0; j < s2Len; j++)
                {
                    if (s1[i + j] != s2[j])
                        break;
                }

                if (s2Len == j)
                {
                    index = i;
                    break;
                }
            }

            return index;

        }
    }
}
