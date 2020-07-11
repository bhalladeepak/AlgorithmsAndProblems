using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Searching
    {
        //LinearSearch
        public bool LinearSearch(int[] inputArray, int sValue)
        {
            //1. Worst case is O(n) for n items
            //2. Best case is O(1) if the value to search is the first item in the list
            int length = inputArray.Length;
            for (int index = 0; index < length; index++)
            {
                if (inputArray[index] == sValue)
                    return true;
            }
            return false;
        }

        //LinearSearchWithSwap to move the common searched intems to the left of the array
        public bool LinearSearchWithSwap(int[] inputArray, int sValue)
        {
            int upperBound = inputArray.Length - 1;
            for (int index = 0; index <= upperBound; index++)
            {
                if (inputArray[index] == sValue && index > inputArray.Length * 0.2)
                {
                    swap(inputArray, index, index-1);
                    return true;
                }
                else
                {
                    if (inputArray[index] == sValue)
                        return true;
                }
            }
            return false;
        }


        private void swap(int[] inputArray, int item1, int item2)
        {
            int temp = inputArray[item1];
            inputArray[item1] = inputArray[item2];
            inputArray[item2] = temp;
        }

        //FindMin, finds the minimum number in the array
        public int FindMin(int[] inputArray)
        {
            int upperBound = inputArray.Length - 1;
            int minValue = inputArray[0];
            for(int index = 1; index <= upperBound; index++)
            {
                if (inputArray[index] < minValue)
                    minValue = inputArray[index];
            }
            return minValue;
        }

        //FindMax, finds the maximum number in the array
        public int FindMax(int[] inputArray)
        {
            int upperBound = inputArray.Length - 1;
            int maxValue = inputArray[0];
            for (int index = 1; index <= upperBound; index++)
            {
                if (inputArray[index] > maxValue)
                    maxValue = inputArray[index];
            }
            return maxValue;
        }

        public bool BinarySearch(int[] inputArray, int sValue)
        {
            int mid, upperBound, lowerBound;
            upperBound = inputArray.Length - 1;
            lowerBound = 0;
            while(lowerBound <= upperBound)
            {
                mid = (lowerBound + upperBound)/2;
                if(inputArray[mid] == sValue)
                    return true;
                else
                    if(inputArray[mid] > sValue)
                        upperBound = mid - 1;
                    else
                        lowerBound = mid + 1;
            }
            return false;
        }

        public bool BinarySearchRecursive(int[] inputArray, int lower, int upper, int sValue)
        {
            bool retunValue = false;
            if (lower > upper)
                retunValue = false;
            else
            {
                int mid = (lower + upper) / 2;
                if (inputArray[mid] == sValue)
                    retunValue = true;
                else if (inputArray[mid] > sValue)
                    BinarySearchRecursive(inputArray, lower, mid - 1, sValue);
                else
                    BinarySearchRecursive(inputArray, mid + 1, upper, sValue);
            }
            return retunValue;
        }
    }
}
