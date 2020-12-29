using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    //Sum of two large numbers
    //Given two numbers as strings. The numbers may be very large (may not fit in long long int), the task is to find sum of these two numbers.
    //Time Complexity : O(n1 + n2) where n1 and n2 are lengths of two input strings representing numbers.
    public static class SumOfTwoLargeNumbers
    {
        public static void PrintSum()
        {
            string str1 = "1100";
            string str2 = "11111";

            string sum = CalculateSum(str1, str2);
            Console.WriteLine();
            Console.WriteLine($"Sum of str1 - {str1} and str2 - {str2} = {sum}");
            Console.WriteLine();
        }

        private static string CalculateSum(string str1, string str2)
        {
            string str = string.Empty;
            int carryOver = 0;
            var s1Length = str1.Length;
            var s2Length = str2.Length;

            //Make sure that str1 is the smallest string. Switch the string 
            if (s1Length > s2Length)
            {
                string temp = str1;
                str1 = str2;
                str2 = temp;
            }

            char[] a1 = str1.ToCharArray();
            char[] a2 = str2.ToCharArray();

            Array.Reverse(a1);
            Array.Reverse(a2);

            for (int i = 0; i < a1.Length; i++)
            {
                int s = (a1[i] - '0' + a2[i] - '0' + carryOver);
                carryOver = s / 10;
                str += (char)(s%10 + '0');
            }

            //Adding remaining digits of larger number
            for (int i = a1.Length; i < a2.Length; i++)
            {
                int s = (a2[i] - '0' + carryOver);
                carryOver = s / 10;
                str += (char)(s % 10 + '0');
            }

            //Add remaining carry
            if (carryOver > 0)
            {
                str += (char)(carryOver % 10 + '0');
            }
    
            string returnSum = new string(str.ToCharArray().Reverse().ToArray());
            return returnSum  ;
        }
    }
}
