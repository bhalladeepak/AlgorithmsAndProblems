using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples.Palindrome
{
    public static class LongestPalindromeSubstring
    {
        public static void PrintLongestPalindrome()
        {
            string str = "aaaabaaa";
            Console.WriteLine($"String to check longest palindrome : {str}");
            FindLongestPalindrome(str);

        }

        private static void FindLongestPalindrome(string str)
        {
            int len = str.Length;
            int left, right;
            int maxLength = 0;
            int start = 0;


            for (int i = 0; i < len; i++)
            {
                left = 0;
                right = i;
                while (left >= 0 && right < len && str[left] == str[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        maxLength = right - left + 1;
                        start = left;
                    }
                    left--;
                    right++;
                }

                left = 0;
                right = i + 1;
                while (left >= 0 && right < len && str[left] == str[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        maxLength = right - left + 1;
                        start = left;
                    }
                    left--;
                    right++;
                }

            }

            PrintSubStr(str, start, start + maxLength - 1);
            Console.WriteLine();

		}

        private static void PrintSubStr(string str, int low, int high)
        {
            Console.WriteLine(str.Substring(low,(high + 1) - low));
        }


    }
}
