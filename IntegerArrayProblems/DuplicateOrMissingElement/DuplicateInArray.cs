using CommonHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    public static class DuplicateInArray
    {
        /*
         * Find Duplicate in Array : Given a read only array of n + 1 integers between 1 and n, find one number that repeats in linear
         *                           time using less than O(n) space and traversing the stream sequentially O(1) times.
         */
        public static void PrintDuplicate()
        {
            int[] a = {3, 4, 1, 4, 1};

            ArrayHelpers.PrintIntArray(a);
            string dup = FindDuplicateUsingMostEfficientWay(a);
            Console.WriteLine($"Duplicate number in the array : {dup}");
        }

        private static int FineDuplicateUsingHash(int[] a)
        {
            int dup = -1;

            Hashtable hTable = new Hashtable();

            for (int i = 0; i < a.Length; i++)
            {
                if (hTable.ContainsKey(a[i]))
                {
                    int count = (int)hTable[a[i]];
                    count++;
                    hTable[a[i]] = count;
                }
                else
                {
                    hTable.Add(a[i], 1);
                }
            }

            foreach (var k in hTable.Keys)
            {
                if ((int) hTable[k] > 0)
                    return dup = (int)k;
            }

            return dup;
        }

        private static string FindDuplicateUsingArray(int[] a)
        {
            //Find the two repeating elements in a given array : You are given an array of n+2 elements. All elements of the array are in range 1 to n. And all elements occur
            //once except two numbers which occur twice. Find the two repeating numbers.
            //For example, array = { 4, 2, 4, 5, 2, 3, 1 } and n = 5
            //The above array has n + 2 = 7 elements with all elements occurring once except 2 and 4 which occur twice.So the output should be 4 2.
            //Time Complexity: O(n)

            //https://www.geeksforgeeks.org/find-the-two-repeating-elements-in-a-given-array/

            string dup = "";

            int[] count = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (count[a[i]] == 1)
                    dup = dup + i.ToString();
                else
                    count[a[i]]++;
            }

            return dup;


        }

        private static string FindDuplicateUsingLoop(int[] a)
        {
            //This method doesn’t use the other useful data provided in questions like range of numbers is between 1 to n and there are only two repeating elements.
            //Time Complexity: O(n * n)
            //Auxiliary Space: O(1)
            
            string dup = "";
            int len = a.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (a[i] == a[j])
                    {
                        dup = $"{dup}, {a[i]}";
                    }
                }
            }
            return dup;
        }

        private static string FindDuplicateUsingMostEfficientWay(int[] a)
        {
            //Given an array of n elements which contains elements from 0 to n-1, with any of these numbers appearing any number of times.
            //Find these repeating numbers in O(n) and using only constant memory space.
            //https://www.geeksforgeeks.org/find-the-two-repeating-elements-in-a-given-array/

            string dup = "";
            int len = a.Length;
            for (int i = 0; i < len; i++)
            {
                if (a[Math.Abs(a[i])] >= 0)
                {
                    a[Math.Abs(a[i])] = -a[Math.Abs(a[i])];
                }
                else
                {
                    dup = $"{dup}, {Math.Abs(a[i])}";
                }

            }
            return dup;
        }
    }
}
