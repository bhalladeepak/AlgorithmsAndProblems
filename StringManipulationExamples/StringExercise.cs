using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public class StringExercise
    {
        //Reverse a string

        //Check if string 2 is a substring of string 1
        //merging 2 string
        //Finding duplicates chars in a string
        public static string ReverseString(string valueToReverse)
        {
            int valueLength = valueToReverse.Length - 1;
            string result = "";
            for (int i = valueLength; i >= 0; i--)
            {
                result += valueToReverse[i];
            }
            return result;
            //Console.WriteLine(result);
            //Console.WriteLine();
        }

        //Check if 2 string are equal
        public static bool StringComparison(string str1, string str2)
        {
            int l1 = str1.Length;
            int l2 = str2.Length;

            if (l1 != l2)
            {
                return false;
            }

            for (int i = 0; i < l1; i++)
            {
                int chStr1 = str1[i];
                int chStr2 = str2[i];

                if (chStr1 != chStr2)
                {
                    return false;
                }
            }
            return true;
        }

        //Remove duplicate characters in a string
        public static string RemoveDuplicateChars(string str)
        {
            //contains a collection of chars in the string
            string encounterChar = string.Empty;

            //store the result in the string
            string result = string.Empty;

            foreach (char c in str)
            {
                if (encounterChar.IndexOf(c) == -1)
                {
                    encounterChar += c;
                    result += c;
                }
               
            }
            return result;
        }

        public static string FindDuplicateChars(string str)
        {
            string uniqueChar = string.Empty;
            string duplicateChar = string.Empty;

            foreach (char c in str)
            {
                if (uniqueChar.IndexOf(c) == -1)
                {
                    uniqueChar += c;
                }
                else
                {
                    duplicateChar += c;
                }
            }

            return duplicateChar;
        }

        public static void PrintAllSubString(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int start = 0; start <= i; start++)
                {
                    string substring = input.Substring(start, i);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
