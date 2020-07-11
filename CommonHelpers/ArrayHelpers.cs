using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommonHelpers
{
    public static class ArrayHelpers
    {
        public static void PrintIntArray(int[] array)
        {

            Console.Write("[");
            for (int i= 0; i < array.Length; i++)
            {
                if ((i + 1) == array.Length)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }


        public static void StringDisplayElements(string[] inputArray)
        {
            int upper = inputArray.Length - 1;
            for (int i = 0; i <= upper; i++)
                Console.Write(inputArray[i] + " ");
            Console.WriteLine();
        }
    }
}
