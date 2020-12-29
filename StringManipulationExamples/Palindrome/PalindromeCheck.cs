using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public static class PalindromeCheck
    {
        public static void CheckPalindrome()
        {
            string str = "malayalam";
            Console.WriteLine($"Input string : {str}");
            PrintIsPalindrome(str);

        }

        private static void PrintIsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            bool isPalindrome = true;
            str = str.ToLower();
            while (left < right)
            {
                char l = (char) str[left];
                char r = (char) str[right];

                if (l != r)
                {
                    isPalindrome = false;
                    break;
                }

                left++;
                right--;
            }

            if(isPalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
            
        }

    }

    public class ReverseANumber
    {
        public int ReverseUsingMod(int inputValue)
        {
            int left = inputValue;
            int reverse = 0;

            while (left > 0)
            {
                int mod = left % 10;
                reverse = reverse * 10 + mod;
                left = left / 10;
            }
            return reverse;
        }

        public int ReversWithoutMod(int inputValue)
        {
            int reverse = 0;
            while (inputValue > 0)
            {
                reverse = reverse * 10 + (inputValue - (inputValue / 10) * 10);
                inputValue = inputValue / 10;
            }
            return reverse;
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if(min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];

                if(char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;
            }
           
        }

        //public ReverseANumber()
        //{

        //}

        //~ReverseANumber()
        //{

        //}
    }
}
