using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace SortingAlgorithms
{
    public class BinarySort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int x = array[i];

                //Find the locaiton to insert using binary search

                int j = Math.Abs(Array.BinarySearch(array, 0, i, x) + 1);

                Array.Copy(array,j,array,j+1,i-j);

                array[j] = x;
            }
            ArrayHelpers.PrintIntArray(array);

        }
    }
}
