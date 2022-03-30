using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    /*
    You are given an array of positive numbers from 1 to n, such that all numbers from 1 to n are present except one number x. You have to find x. The input array is not sorted. 
    Look at the below array and give it a try before checking the solution.
    3712845
        n = 8 missing number = 6
 
     */

    public static class FindMissingNumInArray
    {
        public static void FindMissing()
        {
            string inputStr = "3712845";
            int numberOfElements = 8;

            int missingElement = ExpectedSum(numberOfElements) - SumOfElements(inputStr);

            Console.WriteLine($"Missing element in number {inputStr} is :: {missingElement}");
        }

        private static int SumOfElements(string inputStr)
        {
            int elemntsSum = 0;

            foreach(char c in inputStr)
            {
                elemntsSum += (int)(c - '0');
            }
            return elemntsSum;
        }

        private static int ExpectedSum(int numberOfElemetns)
        {
            int expectedSum = 0;

            for(int i=1; i<= numberOfElemetns; i++)
            {
                expectedSum += i;
            }

            return expectedSum;
        }

    }
}
