
using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SortingAlgorithms
{
    public class BinarySearch
    {
        public static int Search(int[] array, int l, int r, int searchValue)
        {
            while (l <= r)
            {
                int middle = l + (r - l) / 2;

                //check if middle valuse present in the middle
                if (array[middle] == searchValue)
                    return middle;

                // If searchValue greater, ignore left half
                if (array[middle] < searchValue)
                {
                    l = middle + 1;
                }

                // If searchValue is smaller, ignore right half 
                else
                {
                    r = middle - 1;
                }
            }

            // if we reach here, then element was 
            // not present 
            return -1;
        }

        public void FindNumber(int[] array, int searchValue)
        {
            int right = array.Length - 1;
            int index = Search(array, 0, right, searchValue);

            if(index == -1)
                Console.WriteLine("Element not found");
            else
            {
                Console.WriteLine("Element found at index " + index);
            }
        }
    }
}
