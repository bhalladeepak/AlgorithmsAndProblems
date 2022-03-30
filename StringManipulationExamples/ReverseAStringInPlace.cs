using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public static class ReverseAStringInPlace
    {
        public static void ReverseString()
        {
            string test = "ABC";
            Console.WriteLine("String to Reverse : " + test);
            string revString = Reverse(test);
            Console.WriteLine("Reverse String : " + revString);
        }

        //Reverse a string using arrays
        /*
        This is a simple algorithm and time complexity is O(n/2) or O(n) because it needs to iterate over almost half the elements and perform n/2 swapping as well.
        The space complexity of the algorithm is O(1) because no matter how big the array is, it requires the same space
        Read more: https://www.java67.com/2016/01/java-program-to-reverse-array-in-place.html#ixzz76vHZm9TB
         */
        private static string Reverse(string strInput)
        {
            char[] characters = strInput.ToCharArray();
            char temp;
            int iteration = (strInput.Length + 1) / 2;
            int left = 0;
            int right = strInput.Length - 1;

            for(int i =0; i < iteration; i++)
            {
                temp = strInput[left];
                characters[left] = characters[right];
                characters[right] = temp;

                left++;
                right--;
            }

            string returnValue = new string(characters);
            return returnValue;
        }


        //Reverse a string using temp varaible.
        //time complexity is O(n) because it the algorithm iterate over all of the elements
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
    }
}
