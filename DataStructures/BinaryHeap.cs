using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace DataStructures
{
    //Heapify(A, i) A = Array, i = index in the array. This is a recursive function
    //BuildMaxHeap(A) 
    //HeapSort(A) calls BuildMaxHeap and MaxHeapify method
    //https://simpledevcode.wordpress.com/2014/11/25/heapsort-c-tutorial/
    public class BinaryHeap
    {
        private int heapSize;

        #region MaxHeap

        public void BuildMaxHeap(int[] array)
        {
            heapSize = array.Length - 1;
            for(int i = heapSize/2; i >= 0; i--)
            {
                MaxHeapify(array, i);
            }

            Console.Write("Array after BuildMaxHeap function : ");
            ArrayHelpers.PrintIntArray(array);
        }

        public void MaxHeapify(int[] array, int index)
        {
            int left = 2 * index + 1 ;  //Left child
            int right = 2 * index + 2;  //Right Child
            int largest = index;

            if(left <= heapSize && array[left] > array[largest])
            {
                largest = left;
            }
            if(right <= heapSize && array[right] > array[largest])
            {
                largest = right;
            }
            if(largest != index)
            {
                Swap(array, index, largest);
                MaxHeapify(array, largest);
            }
        }

        public Nullable<int> Maximum(int[] array)
        {
            Nullable<int> returnValue = null;
            if (array.Length > 0)
            {
                returnValue = array[0];
                
            }
            return returnValue;
        }

        public int ExtractMaximum(int[] array)
        {
            int max = -1;
            if (heapSize == 0)
            {
                Console.WriteLine("Can’t remove element as queue is empty");
                return max;
            }

            max = array[0];
            array[0] = array[heapSize]; //move the last element in front of the array
            heapSize--;
            
            MaxHeapify(array, 0);
            return max;

        }

        public void IncreaseKey(int[] array, int i, int value)
        {
            if (value < array[i])
            {
                Console.WriteLine("New value is less than the current value, can't be inserted");
                return;
            }

            array[i] = value;
            while (i > 0 && array[i / 2] < array[i])
            {
                Swap(array, i/2, i );
                i = i / 2;
            }
        }
        public void MaxHeapInsert(int[] array, int value)
        {
            heapSize = heapSize + 1;
            array[heapSize] = -1;
            IncreaseKey(array, heapSize, value);

        }
        
        public static void MaxHeapHelper()
        {
            int[] arr = { 4, 5, 1, 6, 7, 3, 2 };
            Console.Write("Input Array for the MaxHeap problem : ");
            ArrayHelpers.PrintIntArray(arr);


            BinaryHeap maxHeap = new BinaryHeap();
            maxHeap.BuildMaxHeap(arr);

            int? maxValue = maxHeap.Maximum(arr);
            Console.WriteLine("Maximum value in the heap is : {0}", maxValue);


            int extractMax = maxHeap.ExtractMaximum(arr);
            Console.WriteLine("Extract Maximum value in the heap is : {0}", extractMax);

            Console.Write("Array after ExtractMaximum : ");
            ArrayHelpers.PrintIntArray(arr);

            maxHeap.MaxHeapInsert(arr, 10);
            Console.Write("Array after Inserting 10 value : ");
            ArrayHelpers.PrintIntArray(arr);


        }
        #endregion

        #region MinHeap


        //Complexity:  O(NlogN)
        public void BuildMinHeap(int[] array)
        {
            //Since we are starting from the 0 element in the array so the heap size is equal to array.Length-1
            heapSize = array.Length - 1;
            for(int i=heapSize/2; i >=0; i--)
            {
                MinHeapify(array, i);
            }

            Console.Write("Array after BuildMinHeap function : ");
            ArrayHelpers.PrintIntArray(array);
        }

        //Complexity:  O(logN)
        public void MinHeapify(int[] array, int index)
        {
            int left = 2 * index + 1;   //Left Child
            int right = 2 * index + 2;  //Right Child 
            int min = index;

            if(left <= heapSize && array[left] < array[min])
            {
                min = left;
            }

            if(right <= heapSize && array[right] < array[min])
            {
                min = right;
            }

            if(min != index)
            {
                Swap(array, index, min);
                MinHeapify(array, min);
            }
        }

        public int? Minimum(int[] array)
        {
            int? returnValue = null;

            if(array.Length > 0)
            {
                returnValue = array[0];
            }
            return returnValue;
        }

        public int ExtractMinimum(int[] array)
        {
            int min = -1;
            if (heapSize == 0)
            {
                Console.WriteLine("Can’t remove element as queue is empty");
                return min;
            }

            min = array[0];
            array[0] = array[heapSize];
            heapSize--;

            MinHeapify(array, 0);
            return min;

        }

        public void DecreaseKey(int[] array, int i, int value)
        {
            //if(value < array[i])
            //{
            //    Console.WriteLine("New value is greater than the current value, can't be inserted");
            //    return;
            //}

            array[i] = value;
            while (i > 0 && array[i / 2] > array[i])
            {
                Swap(array, i / 2, i);
                i = i / 2;
            }
        }

        public void MinHeapInsert(int[] array, int value)
        {
            heapSize = heapSize + 1;
            array[heapSize] = -1;
            DecreaseKey(array, heapSize, value);
        }

        public static void MinHeapHelper()
        {

            int[] arr = { 4, 5, 1, 6, 7, 3, 2 };
            Console.Write("Input Array for the MaxHeap problem : ");
            ArrayHelpers.PrintIntArray(arr);


            BinaryHeap minHeap = new BinaryHeap();
            minHeap.BuildMinHeap(arr);

            int? minValue = minHeap.Maximum(arr);
            Console.WriteLine("Minimum value in the heap is : {0}", minValue);


            int extractMin = minHeap.ExtractMinimum(arr);
            Console.WriteLine("Extract Minimum value in the heap is : {0}", extractMin);

            Console.Write("Array after ExtractMinimum : ");
            ArrayHelpers.PrintIntArray(arr);

            minHeap.MinHeapInsert(arr, 1);
            Console.Write("Array after Inserting 0 value : ");
            ArrayHelpers.PrintIntArray(arr);


            //int[] arr = { 10, 8, 9, 7, 6, 5, 4 };
            //Console.Write("Input Array for the problem : ");
            //ArrayHelpers.PrintIntArray(arr);

            //BinaryHeap heap = new BinaryHeap();
            //// heap.PerformHeapSort(arr);

            //heap.BuildMinHeap(arr);

        }


        #endregion

        #region Shared methods and functions on Heap

        private void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        //Complexity:  O(NlogN)
        public void PerformHeapSort(int[] array)
        {
            BuildMaxHeap(array);
            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Swap(array, 0, i);
                heapSize--;
                MaxHeapify(array, 0);
            }

            Console.Write("Array after HeapSort : ");
            ArrayHelpers.PrintIntArray(array);
        }

        public void MergeHeap(int[] array1, int[] array2)
        {
            int arr1Length = array1.Length;
            int arr2Length = array2.Length;
            int mergeArrLenght = arr1Length + arr2Length;

            int[] mergeArr = new int[mergeArrLenght];

            for(int i = 0; i< arr1Length; i++)
            {
                mergeArr[i] = array1[i];
            }

            for(int j=0; j < arr2Length; j++)
            {
                mergeArr[arr1Length + j] = array2[j];
            }

            //BuildMaxHeap(mergeArr);

            PerformHeapSort(mergeArr);

            //Console.Write("Array after building the max heap : ");
            //ArrayHelpers.PrintIntArray(mergeArr);


        }


        #endregion

    }

}
