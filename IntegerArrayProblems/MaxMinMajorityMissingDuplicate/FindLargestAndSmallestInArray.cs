using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    public static class FindLargestAndSmallestInArray
    {
        public static int FindLargest(int[] inputArray)
        {
            int largest = 0;
            int arrayLength = inputArray.Length;

            if (arrayLength > 0) largest = inputArray[0];

            for (int i = 0; i < arrayLength; i++)
            {
                if (inputArray[i] > largest) largest = inputArray[i];
            }
            return largest;
        }

        public static int FindSmallest(int[] inputArray)
        {
            int smallest = 0;
            int arrayLength = inputArray.Length;

            if (arrayLength > 0) smallest = inputArray[0];

            for (int i = 0; i < arrayLength; i++)
            {
                if (inputArray[i] < smallest) smallest = inputArray[i];
            }

            return smallest;

        }
    }
}
