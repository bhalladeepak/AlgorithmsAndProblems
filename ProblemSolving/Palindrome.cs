using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace ProblemSolving
{
    public static class Palindrome
    {
        /// <summary>
        /// Check for palindrome using Stack
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CheckPalindromeWithStack(string input)
        {
            bool isPalndrome = true;
            Stack<char> cstack = new Stack<char>();
            var inputToUpper = input.ToUpper();

            foreach(char c in inputToUpper)
            {
                cstack.Push(c);
            }

            var noOfItems = cstack.Count();

            for(int i =0; i< noOfItems; i++)
            {
                if(inputToUpper[i] != cstack.Pop())
                {
                    isPalndrome = false;
                    break;
                }
            }

            if(isPalndrome)
            {
                return "Palindrome";
            }
            else
            {
                return "Not Palindrome";
            }

        }

        /// <summary>
        /// Check for palindrome by comparing the characters from the start to end of the string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool CheckPalindromeWithCharacterComparision(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;
            }

        }

        public static bool CheckPalindromeWithCharacterComparision_Version2(string ValueToCheck)
        {
            int length = ValueToCheck.Length;
            bool result = true;
            for (int i = 0; i < length / 2; i++)
            {
                if (ValueToCheck[i] != ValueToCheck[length - i - 1])
                    result = false;

            }
            return result;
        }
    }
}
