using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace IntegerArrayProblems
{
    public static class MaxIndexDistance
    {
        /*
         *Max Distance : Given an array a of integers, find the maximum of j - i subjected to the constraint of A[i] <= A[j].
         */
        public static void PrintMaxDistance()
        {
            //int[] a = {1, 2, 3, 4, 5, 6}; //Output = 4
            int[] a = { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 }; //Output: 8 ( j = 8, i = 0)


            ArrayHelpers.PrintIntArray(a);
            int max = FindMaxBestTimeComplexity(a);
            Console.WriteLine($"Max Distance in the array : {max}");

        }

        /*
        static int FindMax(int[] a)
        {
            int max = 0;
            int i = 0, j = 0;

            for (int c = 1; c < a.Length; c++)
            {
                if (a[i] <= a[c])
                {
                    j = c;
                }
                else
                {
                    i = c;
                }
            }
            max = (j - i) - 1;
            max = max < 0 ? 0 : max;
            return max;
        }
        */

        static int FindMaxWorstTimeComplexity(int[] a)
        {
            //Time Complexity : O(n^2)
            int maxDiff = 0;
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j] > a[i] && maxDiff < j - i)
                        maxDiff = j - i;
                }
            }
            return maxDiff;
        }

        static int FindMaxBestTimeComplexity(int[] a)
        {
            //Time Complexity : O(n)
            int i, j;
            int n = a.Length;

            int[] LMin = new int[n];
            int[] RMax = new int[n];

            LMin[0] = a[0];
            for (i = 1; i < n; i++)
            {
                LMin[i] = Min(LMin[i - 1], a[i]);
            }

            RMax[n - 1] = a[n - 1];
            for (j = n - 2; j >= 0; j--)
            {
                RMax[j] = Max(RMax[j + 1], a[j]);
            }

            i = 0;
            j = 0;
            int maxDiff = -1;
            while (i < n && j < n)
            {
                if (LMin[i] < RMax[j])
                {
                    maxDiff = Max(maxDiff, j - i);
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return maxDiff;
        }




        static int Max(int x, int y)
        {
            return x > y ? x : y;
        }

        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
    }
}
