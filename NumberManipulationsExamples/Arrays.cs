using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public static class Arrays
    {

        public static int[] Merge(int[] array1, int[] array2)
        {
            int newArraySize = array1.Count() + array2.Count();
            int[] mergeArray = new int[newArraySize];

            int i = 0, j = 0, k = 0;

            while (k < newArraySize)
            {
                if (j == array2.Length || ((i < array1.Length) && (array1[i] < array2[j])))
                {
                    mergeArray[k] = array1[i];
                    i++;
                }
                else
                {
                    mergeArray[k] = array2[j];
                    j++;
                }
                k++;
            }
            return mergeArray;
        }

        public static int[] SegragateOneAndZeros(int[] inputArray)
        {
            int length = inputArray.Length;
            int left = 0, right = length - 1;
            //int OneCount = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    if (inputArray[i] == 1)
            //        OneCount++;
            //}
            while (left < right)
            {
                /* Increment left index while we see 0 at left */
                while (inputArray[left] == 0 && left < right)
                    left++;
                /* Decrement right index while we see 1 at right */
                while (inputArray[right] == 1 && left < right)
                    right--;
                /* If left is smaller than right then there is a 1 at left and a 0 at right.  Exchange it */
                if (left < right)
                {
                    inputArray[left] = 0;
                    inputArray[right] = 1;
                    left++;
                    right--;
                }
            }
            return inputArray;
        }


    }
}
