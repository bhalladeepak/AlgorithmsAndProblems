using System;
using CommonHelpers;

namespace SortingAlgorithms
{
    class SelectionSort
    {

        public void Sort(int[] inputArray)
        {
            //1. Consiste of 2 for loop
            //2. The outer loop moves from the first element in the array to the next to last element
            //3. the inner loop moves from the second element of the array to the last element looking for values that are smaller than the element currently being 
            //   pointed at by the outer loop.
            //4. The worst case performance for bubble sort is O(n^2)
            //5. The best case performance for bubble sort is O(n^2)
            //6. The average case performance for bubble sort is O(n^2)

            int length = inputArray.Length;
            int min, temp;
            for (int outer = 0; outer < length; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner < length; inner++)
                {
                    if (inputArray[inner] < inputArray[min])
                        min = inner;
                }
                
                temp = inputArray[outer];
                inputArray[outer] = inputArray[min];
                inputArray[min] = temp;
                ArrayHelpers.PrintIntArray(inputArray);
            }
        }

        public void Sort(string[] inputArray)
        {
            int length = inputArray.Length;
            int min;
            string temp = null;

            for(int outer = 0; outer < length; outer ++)
            {
                min = outer;
                for(int inner = outer + 1; inner < length; inner ++)
                {
                    if (inputArray[inner].CompareTo(inputArray[min]) < 0)
                        min = inner;
                }

                temp = inputArray[outer];
                inputArray[outer] = inputArray[min];
                inputArray[min] = temp;
                ArrayHelpers.StringDisplayElements(inputArray);
            }
        }

        





    }
}
