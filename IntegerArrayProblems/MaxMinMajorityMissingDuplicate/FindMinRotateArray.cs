using CommonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    //https://www.programcreek.com/2014/02/leetcode-find-minimum-in-rotated-sorted-array/
    //Find Minimum in Rotated Sorted Array
    //Suppose a sorted array is rotated at some pivot unknown to you beforehand. (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
    //Find the minimum element.You may assume no duplicate exists in the array.
    //Analysis: This problem is a binary search and the key is breaking the array to two parts, so that we can work on half of the array each time.
 

    public static class FindMinRotateArray
    {
        public static void PrintMin()
        {
            //0 1 2 4 5 6 7
            //4 5 6 7 0 1 2
            int[] rotatedArray = {11, 12, 15, 18, 2, 5, 6, 8};
            int min = FindMinUsingIteration(rotatedArray);
            ArrayHelpers.PrintIntArray(rotatedArray);
            Console.WriteLine("Minimum : " + min);
        }

        private static int FindMinUsingIteration(int[] A)
        {
            int min = -1;
            if (A == null || A.Length == 0)
                return min;

            int i = 0;
            int j = A.Length - 1;

            while (i <= j)
            {
                if (A[i] < A[j])
                    return min = A[i];

                int m = (i + j) / 2;
                if (A[m] > A[i])
                {
                    i = m + 1;
                }
                else
                {
                    j = m;
                }
            }
            return min;

        }

        //private static int FindMinUsingRecursion(int[] A)
        //{

        //}

    }
}
