using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    /*
     * Write a function
        class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, returns the number of distinct values in array A.

        For example, given array A consisting of six elements such that:
         A[0] = 2    A[1] = 1    A[2] = 1
         A[3] = 2    A[4] = 3    A[5] = 1
        the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..100,000];
        each element of array A is an integer within the range [−1,000,000..1,000,000].
     */
    public static class DistinctValuesInArray
    {

        public static int FindNoOfDistinctValues(int[] A)
        {
            int distinct = 0;

            Array.Sort(A);
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i] != A[i + 1]) distinct++;
            }
            return distinct;
        }

        public static int FindNoOfDistinctValuesWithSort(int[] A)
        {
            int distinct = 0;
            var length = A.Length;
            
            if (length > 0) distinct++;

            var sortedArray = SortArray(A);
            for (int i = 0; i < length - 1; i++)
            {
                if (sortedArray[i] != sortedArray[i + 1]) distinct++;
            }
            return distinct;
        }

        public static int[] SortArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            return A;
        }
    }
}
