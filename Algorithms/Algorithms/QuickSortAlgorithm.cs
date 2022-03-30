using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    /*
     * https://www.geeksforgeeks.org/quick-sort/
     * https://www.interviewbit.com/tutorial/quicksort-algorithm/#quicksort-algorithm
     * 
     * 
     */

    public class QuickSortAlgorithm
    {

        public void Demo()
        {
            int[] arr = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            Console.Write("Array befor sort : ");
            PrintArray(arr);
            Console.WriteLine();
            Console.Write("Array after sort : ");
            QuickSort(arr, 0, arr.Length - 1);

            PrintArray(arr);
        }

        private void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }

        }

        private int Partition(int[] arr, int low, int high) 
        {
            int pivot = arr[high];
            int i = low - 1;

            for(int j = low ; j<=high ; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }

            }
            Swap(arr, i + 1, high);
            return (i + 1);

        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void PrintArray(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

    }
}
