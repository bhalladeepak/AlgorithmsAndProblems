using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    /*
     * https://www.geeksforgeeks.org/find-a-repeating-and-a-missing-number/
     * You are given a read only array of n integers from 1 to n.
     * Each integer appears exactly once except A which appears twice and B which is missing.
       Return A and B.

       Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
       Note that in your output A should precede B.

       Example:
           Input:[3 1 2 5 3] 
           Output:[3, 4] 
           A = 3, B = 4
     */
    public static class RepeatMissingNumber
    {
        public static void Print()
        {
            int[] a = { 3, 1, 2, 5, 3 };
            //FindRepeatMissing(a);

            FindRepeatMissingUsingFormula(a);
        }

        /* private static void FindRepeatMissing(int[] a)
         {
             int[] r = new int[2];
             int repeat = a[0];

             for (int i = 0; i < a.Length; i++)
             {
                 if (repeat == a[i])
                 {
                     repeat = a[i];
                     r[0] = repeat;
                 }
             }

             Console.WriteLine($"A = {r[0]}");
             Console.WriteLine($"B = {r[1]}");
         }
        */

        private static void FindRepeatMissingUsingFormula(int[] a)
        {
            int len = a.Length;
            int miss = 0, repeat = 0;

            int s = (len * (len + 1)) / 2;
            int p = (len * (len + 1) * (2 * len + 1)) / 6;

            for (int i = 0; i < len; i++)
            {
                s -= a[i];
                p -= a[i] * a[i];
            }

            miss = (s + p / s) / 2;
            repeat = miss - s;

            Console.WriteLine("Missing : " + miss);
            Console.WriteLine("Repeat : " + repeat);
        }
    }
}
