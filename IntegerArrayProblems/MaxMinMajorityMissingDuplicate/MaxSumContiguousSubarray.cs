using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    /*
     *Largest Sum Contiguous Subarray : Write an efficient program to find the sum of contiguous subarray within a one-dimensional array
     * of numbers which has the largest sum.
     *https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
     */
    public static class MaxSumContiguousSubarray
    {
        public static void PrintSum()
        {
            //int[] a = new int[] {1, 2, 3, 4, -10};
            int[] a = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int sum = Calculate(a);
            Console.WriteLine($"Maximum sum contiguous subarray {sum}");
        }
        private static int Calculate(int[] a)
        {
            int maxSumSoFar = 0;
            int maxEndSum = 0;

            for (int i = 1; i < a.Length; i++)
            {
                maxEndSum = maxEndSum + a[i];
                if (maxSumSoFar < maxEndSum)
                    maxSumSoFar = maxEndSum;
                if (maxEndSum < 0)
                    maxEndSum = 0;
            }


            return maxSumSoFar;
        }
    }
}
