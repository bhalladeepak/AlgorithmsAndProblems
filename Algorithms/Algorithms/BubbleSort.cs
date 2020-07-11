using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        public void Bubble(int[] inputArray)
        {
            //1. Consiste of 2 for loop
            //2. The outer loop run from 1 to ArrayLength in the array
            //3. The inner loop ruuns from [outer + 1] to ArrayLength
            //3. At the end of the each outer loop the highest number moved to the right of the array.
            //4. The worst case performance for bubble sort is O(n^2)
            //5. The best case performance for bubble sort is O(n)
            //6. The average case performance for bubble sort is O(n^2)

            int temp;
            int length = inputArray.Length;
            for (int outer = 0; outer < length; outer++)
            {
                for (int inner = outer + 1; inner < length; inner++)
                {
                    if ((int)inputArray[outer] > inputArray[inner])
                    {
                        temp = inputArray[inner];
                        inputArray[inner] = inputArray[outer];
                        inputArray[outer] = temp;
                    }
                }
                ArrayHelpers.PrintIntArray(inputArray);

            }
        }


        public void BubbleString(string[] inputArray)
        {
            string temp;
            int length = inputArray.Length;
            for (int outer = 0; outer < length; outer++)
            {
                for (int inner = outer + 1; inner < length; inner++)
                {
                    if (inputArray[outer].CompareTo(inputArray[inner]) > 0)
                    {
                        temp = inputArray[inner];
                        inputArray[inner] = inputArray[outer];
                        inputArray[outer] = temp;
                    }
                }
                ArrayHelpers.StringDisplayElements(inputArray);

            }
        }

    }
}
