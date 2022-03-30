using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] unsortedArray = new int[] { 12, 5, 45, 10, 20, 2, 1 };
            int[] sortedArray = new int[] { 1, 3, 5, 10, 39, 50, 57 };
            string[] stringArray = new string[] { "zz", "y", "aaz", "aa" };
            SelectionSort sort = new SelectionSort();
            Searching search = new Searching();
            bool result;



            #region 1. Insertion Sort

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(unsortedArray);
            Console.WriteLine();
            insertionSort.SortVersion2(unsortedArray);
            Console.WriteLine();
            #endregion

            #region 2. Merge sort

            int[] arr = { 38, 27, 43, 3, 9, 82, 10}; // this is the array to be sorted
            MergeSortArray merge = new MergeSortArray();

            //// Calling Merge Procedure
            merge.Mergesort(arr, 0, arr.Length - 1);
            ArrayHelpers.PrintIntArray(arr);            



            //// Printing Sorted array. after merge sort
            //foreach (int a in arr)
            //{
            //    Console.Write(a + " ");
            //}

            #endregion

            #region 3. Binary sort

            Console.WriteLine("Binary Sort");
            ArrayHelpers.PrintIntArray(unsortedArray);
            BinarySort binarySort = new BinarySort();
            binarySort.Sort(unsortedArray);

            #endregion

            #region 4. Binary Search
            Console.WriteLine("Binary search");
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.FindNumber(sortedArray,57);


            #endregion

            #region 5. Quick Sort
            Console.WriteLine();
            Console.WriteLine("Quick Sort");
            QuickSortAlgorithm quickSort = new QuickSortAlgorithm();
            quickSort.Demo();
            
            #endregion

            //CArray nums = new CArray();
            //Random rnd = new Random(100);
            //for(int i=0; i<10; i++)
            //    nums.Insert((int)(rnd.NextDouble() * 100));





            //sort.StringBubbleSort(stringArray);
            //sort.BubbleSort(unsortedArray);



            //sort.SelectionSort(unsortedArray);
            //sort.SelectionSort(stringArray);


            //result = search.LinearSearch(unsortedArray, 60);
            //Console.WriteLine(result);

            //result = search.LinearSearchWithSwap(unsortedArray, 10);
            //Console.WriteLine(result);

            //int min = search.FindMin(unsortedArray);
            //Console.WriteLine(min);

            //result = search.BinarySearch(sortedArray, 57);
            //Console.WriteLine(result);

            //result = search.BinarySearchRecursive(sortedArray, 0, 6, 50);
            //    Console.WriteLine(result);

            //MergeTwoSortArray mergeArray = new MergeTwoSortArray();
            //mergeArray.mergeSortedArray();

            Console.ReadLine();


        }
    }
}
