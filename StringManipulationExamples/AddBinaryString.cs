using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public static class AddBinaryString
    {
        /*
         Program to add two binary strings
         Given two binary strings, return their sum (also a binary string).
         Input:  a = "11", b = "1"
         Output: "100" 
         https://www.geeksforgeeks.org/program-to-add-two-binary-strings/
         */
        public static void PrintAddition()
        {
            string s1 = "11";
            string s2 = "1";

            Console.WriteLine($"Main string s1 : {s1}, s2 : {s2}");
            
            string sumFor = AddStringUsingFor(s1, s2);
            string sumWhile = AddStringUsingWhile(s1, s2);


            Console.WriteLine($"Addition of s1 and s2 using For is : {sumFor}");
            Console.WriteLine($"Addition of s1 and s2 using While is : {sumWhile}");
        }

        private static string AddStringUsingFor(string s1, string s2)
        {
            string sum = string.Empty;
            
            int s1Len = s1.Length;
            int s2Len = s2.Length;
            int s = 0;

            int diff = s1Len - s2Len;

            for (int i = s1Len - 1; i >= 0; i--)
            {
                s += s1[i] - '0';
                if (i - diff >= 0)
                {
                    s += s2[i - diff] - '0';
                }
                sum = (char)(s % 2 + '0') + sum;
                s = s / 2;
            }

            return sum = s + sum;
        }

        private static string AddStringUsingWhile(string s1, string s2)
        {
            string sum = string.Empty;
            int i = s1.Length - 1;
            int j = s2.Length - 1;
            int s = 0;

            while (i >= 0 || j >= 0 || s == 1)
            {
                s += ((i >= 0) ? s1[i] - '0' : 0);
                s += ((j >= 0) ? s2[j] - '0' : 0);

                sum = (char)(s%2 + '0') + sum;

                s = s / 2; //Carryover
                i--;
                j--;
            }

            return sum;
        }
    }
}
