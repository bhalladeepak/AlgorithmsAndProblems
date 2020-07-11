using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysExcercise
{
    class CheckSumInAnArray
    {
        public int CheckValueInAnArray(int[] intArray, int valueToCheck)
        {

            //int[] intArray = new int[] { 1, 3, 4, 5, 7, 4, 64, 5, 7, 9, 20 };
            //string[] names = { "deepak", "Alex" };
            //int valueToCheck = 10;
            int diff = valueToCheck;
            int sum = 0;

            Console.ReadLine();
            Array.Sort<int>(intArray);
            Array.Reverse(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] <= diff)
                    sum = sum + intArray[i];


                if (valueToCheck == sum)
                    Console.WriteLine("{0}", sum);

                else
                    diff = valueToCheck - sum;

                //Console.WriteLine("{0}", sum);
                //Console.ReadLine();
            }

            //System.Diagnostics.Debug.WriteLine(sum);
            Console.WriteLine("{0}", sum);
            Console.ReadLine();
            return sum;


        }
    }
}
