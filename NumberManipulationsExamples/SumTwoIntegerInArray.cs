using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public static class SumTwoIntegerInArray
    {

        /*
        2. Determine if the sum of two integers is equal to the given value
        Given an array of integers and a value, determine if there are any two integers in the array whose sum is equal to the given value. Return true if the sum exists and return false if it does not. Consider this array and the target sums:
            5712843
            Target Sum107+3=10, 2+8=10
            Target Sum19No 2 values sum up to 19
                Runtime Complexity: Linear, O(n)O(n)
                Memory Complexity: Linear, O(n)O(n)
        You can use the following algorithm to find a pair that add up to the target (say val).
        •	Scan the whole array once and store visited elements in a hash set.
        •	During scan, for every element e in the array, we check if val - e is present in the hash set i.e. val - e is already visited.
        •	If val - e is found in the hash set, it means there is a pair (e, val - e) in array whose sum is equal to the given val.
        •	If we have exhausted all elements in the array and didn’t find any such pair, the function will return false

         */
        public static void Execute()
        {
            string strNumber = "5712843";
            int sumToCheck = 10;

            bool result = CheckTwoIntegerInArray(strNumber, sumToCheck);
            Console.WriteLine($"Looking for sum {sumToCheck} in number {strNumber} :: {result}");

        }

        private static bool CheckTwoIntegerInArray(string strNumber, int sumToCheck)
        {
            //1. Pick an element and strore in a varaible currentNumber
            //2. Substract the current from sumToCheck and store in a variable numberToCheck
            //3. If the number is found in the hashtable set the result to true and break.
            //4. If the number is not found store the currentNumber in the hashtable.
            bool result = false;

            //convert string into integer array
            //string[] strArray = strNumber.Split("");
            int[] intArray = new int[strNumber.Length];
            Hashtable numbersHash = new Hashtable();



            for(int i = 0; i < strNumber.Length; i++)
                intArray[i] = int.Parse(strNumber[i].ToString());

            for(int i = 0; i < intArray.Length; i++)
            {
                int currentNumber = intArray[i];
                int numberToCheck = sumToCheck - currentNumber;

                if(numbersHash.ContainsKey(numberToCheck))
                {
                    result = true;
                    break;
                }
                else
                {
                    numbersHash.Add(currentNumber, currentNumber);
                }
            }
            return result;

        }
    }
}
