using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public class Palindrome
    {
        static bool CheckPalindrome(string ValueToCheck)
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
