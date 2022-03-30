using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSortArray
    {
        /* Procedure for merging two sorted array. 
         * Note that both array are part of single array. arr1[start.....mid] and arr2[mid+1 ... end]*/
        //https://www.geeksforgeeks.org/merge-sort/
        //https://www.interviewbit.com/tutorial/merge-sort-algorithm/

        public void MergeArray(int[] arr, int start, int mid, int end)
        {
            /* Create a temporary array for storing merged array (Length of temp array will be 
             * sum of size of both array to be merged)*/
            int[] temp = new int[end - start + 1];

            int i = start;
            int j = mid + 1;
            int k = 0;

            // Now traverse both array simultaniously and store the smallest element of both to temp array
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            // If there is any element remain in first array then add it to temp array
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            // If any element remain in second array then add it to temp array
            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
            // Now temp has merged sorted element of both array

            // Traverse temp array and store element of temp array to original array
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++;
            }
        }

        // Recursive Merge Procedure
        public void Mergesort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                Mergesort(arr, start, mid);
                Mergesort(arr, mid + 1, end);
                MergeArray(arr, start, mid, end);
            }

            
        }
    }
}
