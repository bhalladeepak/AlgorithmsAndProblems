using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public class Palindrome
    {
        public void CheckPalindrome(int num)
        {
            ReverseANumber objReverse = new ReverseANumber();
            int reverseNum = objReverse.ReverseUsingMod(num);

            if (num == reverseNum)
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
