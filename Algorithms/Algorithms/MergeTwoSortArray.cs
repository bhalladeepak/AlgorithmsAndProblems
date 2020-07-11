using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeTwoSortArray
    {
        //Run time = O(n+m)
        public void mergeSortedArray()
        {
            int[] array1 = new int[] { 3, 7, 11, 14, 15 };
            int[] array2 = new int[] { 1, 2, 11, 16 };
          //int[] array2 = new int[] {};// { 1, 2, 11, 16 };

           //array1 = merge(array1, array2, 4);
           //array1 = merge(array1, array2);
          array1 = mergeArrays(array1, array2);
            for (int i = 0; i < array1.Length; i++)
                Console.Write(array1[i] + ", ");
        }

        public int[] merge(int[] array1, int[] array2, int longestArraySize)
        {
            int lArray = longestArraySize;
            int sArray = array2.Length - 1;

            Array.Resize(ref array1, lArray + sArray + 2);

            while(lArray >= 0 && sArray >= 0)
            {
                if(array2[sArray] > array1[lArray])
                {
                    array1[lArray + sArray + 1] = array2[sArray];
                    sArray--;
                }
                else
                {
                    array1[lArray + sArray + 1] = array1[lArray];
                    lArray--;
                }
            }

            while(sArray >= 0)
            {
                array1[sArray] = array2[sArray];
                sArray--;
            }

            return array1;
        }

        public int[] merge(int[] array1, int[] array2)
        {
          int array1Size = array1.Length - 1;
          int array2Size = array2.Length - 1;
          int newArraySize = array1Size + array2Size + 2;

          int[] mergeArray = new int[newArraySize];
          try
          {
            while (array1Size >= 0 && array2Size >= 0)
            {
              if (array1[array1Size] > array2[array2Size])
              {
                mergeArray[newArraySize - 1] = array1[array1Size];
                array1Size--;
                newArraySize--;
              }
              else
              {
                mergeArray[newArraySize - 1] = array2[array2Size];
                array2Size--;
                newArraySize--;

              }
            }
            while (array1Size >= 0)
            {
              mergeArray[array1Size - 1] = array1[array1Size];
              array1Size--;
              newArraySize--;
            }
            while (array2Size >= 0)
            {
              mergeArray[newArraySize - 1] = array2[array2Size];
              array2Size--;
              newArraySize--;
            }

            return mergeArray;
          }
          catch (ArgumentNullException ane)
          {
            Console.WriteLine("Input parameters are null");
            return null;
          }
          catch (IndexOutOfRangeException e)
          {
            Console.WriteLine("Array index not in range");
            return null;
          }
          catch (Exception e)
          {
              Console.WriteLine("Array index not in range");
              return null;
          }
        }

        private int[]mergeArrays(int[] array1, int[] array2)
        {
            var mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;
            while (k < mergedArray.Length)
            {
                if (i == array1.Length || j == array2.Length)
                {
                    if (i <= j)
                    {
                        mergedArray[k] = array1[i];
                        i++;
                    }
                    else
                    {
                        mergedArray[k] = array2[j];
                        j++;
                    }
                }
                else
                {
                    if (array1[i] < array2[j])
                    {
                        mergedArray[k] = array1[i];
                        i++;
                    }
                    else
                    {
                        mergedArray[k] = array2[j];
                        j++;
                    }
                }
                k++;
            }
            return mergedArray;
        }
        
    }


}
