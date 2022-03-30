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
            string mainStr = "geeksfogeeforks";
            string subStr = "for";

            int index = CheckForSubstringSecondApproach(mainStr, subStr);

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

        private static int CheckForSubstring(string sub, string main)
        {
            int index = -1;
            int innerCounter = 0;

            for (int i = 0; i < main.Length; i++)
            {
                innerCounter = i;
                if (main[i] == sub[0])
                {
                    for (int k = 0; k < sub.Length; k++)
                    {
                        if (sub[k] == main[innerCounter])
                        {
                            innerCounter++;
                        }
                    }
                }
                if (sub.Length == (innerCounter - i))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private static int CheckForSubstringSecondApproach(string main, string sub)
        {
            int returnIndex = -1;
            int counter = 0;

            while (counter < main.Length)
            {
                if (sub[0] == main[counter])
                {
                    returnIndex = counter;
                    counter++;
                    int i;
                    for (i = 1; i < sub.Length; i++)
                    {
                        if (sub[i] == main[counter])
                            counter++;
                        else
                            break;

                    }
                    if (returnIndex == counter - i && i == sub.Length)
                    {
                        break;
                    }
                    else
                    {
                        returnIndex = -1;
                    }
                }
                counter++;
            }
            return returnIndex;

        }
    }
}
