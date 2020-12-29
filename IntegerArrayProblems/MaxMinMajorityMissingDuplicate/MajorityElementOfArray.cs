using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace IntegerArrayProblems
{
    public static class MajorityElementOfArray
    {

        public static void PrintMajority()
        {
            //int[] a = { 8, 8, 67, 67, 67, 1, 1, 1, 1, 67, 67, 67, 2, 67, 67 };
            int[] a = { 1, 0, 1, 2, 1, 3, 1, 4, 1, 5, 1 };
            //int[] a = { 3, 3, 4, 2, 4, 4, 2, 4, 4, 3, 3, 2, 3, 1, 3 }; //Output : 3

            ArrayHelpers.PrintIntArray(a);
            FindMajorityInEfficinetWay(a);

            FindDominantUsingHashTable(a);

            FindMajorityMostEfficient(a);
        }

        private static void FindDominantUsingHashTable(int[] a)
        {
            /*
             * Complexity Analysis:
                Time Complexity: O(n).
                One traversal of the array is needed, so the time complexity is linear.
                Auxiliary Space : O(n).
                Since a HashTable requires linear space.
             */
            int len = a.Length;
            int majorityMark = len / 2;
            Hashtable table = new Hashtable();

            for (int i = 0; i < len; i++)
            {
                //Check if the table contains the key, if yes then increase the count if the count is 
                if (table.ContainsKey(a[i]))
                {
                    int value = (int)table[a[i]];
                    value++;
                    table[a[i]] = value;
                    if (value >= majorityMark)
                    {
                        Console.WriteLine($"Majority element in the array is : {a[i]}");
                        return;
                    }

                }
                else
                {
                    table.Add(a[i], 1);
                }

            }
            Console.WriteLine(" No Majority element");
        }



        private static void FindMajorityInEfficinetWay(int[] a)
        {
            /*
                Compelxity Analysis:
                Time Complexity: O(n*n). A nested loop is needed where both the loops traverse the array from start to end, so the time complexity is O(n^2).
                Auxiliary Space : O(1).  As no extra space is required for any operation so the space complexity is constant.
                https://www.geeksforgeeks.org/majority-element/
             *
             */
            int candidate = 0;
            int counter = 0;
            int len = a.Length;

            for (int i = 0; i < len; i++)
            {
                int tempCandidate = a[i];
                int tempCounter = 1;
                
                for (int j = i + 1; j < len; j++)
                {
                    if (a[j] == tempCandidate)
                        tempCounter++;
                }

                if (tempCandidate != candidate && tempCounter > counter)
                {
                    candidate = tempCandidate;
                    counter = tempCounter;
                }
            }

            // if maxCount is greater than n/2  
            // return the corresponding element  
            if (counter >= len / 2)
                Console.WriteLine($"Majority element in the array is : {candidate}");
            else
                Console.WriteLine("No Majority Element");
        }


        private static void FindMajorityMostEfficient(int[] a)
        {
            int majIndex = FindCandidate(a);

            IsMajority(a, majIndex);
        }

        private static int FindCandidate(int[] a)
        {
            int majIndex = 0, count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[majIndex] == a[i])
                    count++;
                else
                    count--;

                if (count == 0)
                {
                    majIndex = i;
                    count++;
                }
            }
            return majIndex;
        }

        private static void IsMajority(int[] a, int majIndex)
        {
            int majMark = a.Length / 2;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[majIndex])
                    count++;
            }

            if (count >= majMark)
                Console.WriteLine($"Majority element in the array is : {a[majIndex]}");
            else
                Console.WriteLine("No Majority Element");

        }

    }
}
