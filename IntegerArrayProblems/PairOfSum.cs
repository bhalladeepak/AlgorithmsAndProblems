using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace IntegerArrayProblems
{
    public class PairOfSum
    {
        /**
         * Prints all pair of integer values from given array whose sum is is equal to given number. 
         * complexity of this solution is O(n^2) 
        **/

        /*
       Approach 1:
       The naive way to do this would be to check all combinations (n choose 2). This exhaustive search is O(n2).

        Approach 2:  
         A better way would be to sort the array. This takes O(n log n) 
        Then for each x in array A, use binary search to look for T-x. This will take O(nlogn).
        So, overall search is  O(n log n)

        Approach 3 : 
        The best way would be to insert every element into a hash table (without sorting). This takes O(n) as constant time insertion.
        Then for every x, we can just look up its complement, T-x, which is O(1).
        Overall the run time of this approach is O(n).  
             
             
       */

        //todo: Print no pair found if there is no pair

        static void PrintPairsUsingBruteForce(int[] array, int sum)
        {
            for(int i = 0; i< array.Length; i++)
            {
                int first = array[i];
                for(int j = i +1; j < array.Length; j++)
                {
                    int second = array[j];
                    int tempSum = first + second;
                    if( tempSum == sum)
                    {
                        Console.WriteLine("({0},{1})", i, j);
                        break;
                    }

                }
            }
        }

        static void PrintPairsUsingDictionary(int[] array, int sum)
        {
            //Step 1 : Convert the array into dictionary
            Dictionary<int, int> arrayDict = new Dictionary<int, int>();
            for (int i =0; i< array.Length; i++)
            {
                arrayDict.Add(i, array[i]);
            }

            //Step 2 : Loop through each key in the dictionary and find the matching value  
            foreach (var item in arrayDict)
            {
                int valueToCheck = sum - item.Value;
                if (arrayDict.ContainsValue(valueToCheck))
                {
                    int pair = arrayDict.FirstOrDefault(x => x.Value == valueToCheck).Key;
                    Console.WriteLine("{0}{1}", item.Key,  pair);

                }
            }
        }



        public static void PairOfSumHelpers()
        {
            
            int[] array = { 2, 4, 3, 5, 2, 8, 9 };
            int sumToCheck = 6;
            Console.WriteLine("USING BRUTE FORCE");
            ArrayHelpers.PrintIntArray(array);
            Console.WriteLine("Input Sum : " + sumToCheck);
            Console.WriteLine("Integer numbers, whose sum is equal to value : " + sumToCheck);
            PrintPairsUsingBruteForce(array, sumToCheck);

            PrintPairsUsingDictionary(array, sumToCheck);


            

        }
    }
}
