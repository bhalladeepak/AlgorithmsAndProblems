using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    /*
     *Given a string A.
            Return the string A after reversing the string word by word.
            NOTE:
            A sequence of non-space characters constitutes a word.
            Your reversed string should not contain leading or trailing spaces, even if it is present in the input string.
            If there are multiple spaces between words, reduce them to a single space in the reversed string.

     */
    public static class ReverseString
    {
        public static void PrintReverse()
        {
            string str = "the sky is  blue";
            string revStr = ReverseUsingForLoop(str);

            Console.WriteLine();
            Console.WriteLine($"Input String : {str}");
            Console.WriteLine($"Reverse String : {revStr}");
            Console.WriteLine();
        }

        private static string Reverse(string input)
        {
            string revStr = "";
            string[] arr = input.Split(' ');
            int head = 0;
            int tail = arr.Length - 1;
            while (head < tail)
            {
                string tmp = arr[tail].Trim();
                arr[tail] = arr[head].Trim();
                arr[head] = tmp;

                head++;
                tail--;
            }

            revStr = string.Join(" ", arr);
            return revStr;

        }

        private static string ReverseUsingForLoop(string input)
        {
            string reverse = string.Empty;

            string[] a = input.Split(' ');

            for (int i = a.Length - 1; i >= 0; i--)
            {
                string str = a[i].Trim();
                if (!string.IsNullOrEmpty(str))
                {
                    reverse = $"{reverse}{str} ";
                }
            }
            return reverse;

        }
    }
}
