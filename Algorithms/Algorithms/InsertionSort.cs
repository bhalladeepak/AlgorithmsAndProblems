using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonHelpers;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        public void Sort(int[] inputArray)
        {
            //1. The Insertion sort has two loops. 
            //2. The outer loop moves element by element through the array 
            //3. The inner loop compares the element chosen in the outer loop to the element next to it in the array. If the element selected by the
            //   outer loop is less than the element selected by the inner loop, array elements are shifted over to the right to make room for the 
            //   inner loop element
            int length = inputArray.Length;
            int temp, inner;
            for (int outer = 0; outer < length; outer++)
            {
                temp = inputArray[outer];
                inner = outer;
                while (inner > 0 && inputArray[inner - 1] >= temp)
                {
                    inputArray[inner] = inputArray[inner - 1];
                    inner -= 1;
                }
                inputArray[inner] = temp;
                ArrayHelpers.PrintIntArray(inputArray);
            }
        }


        public void SortVersion2(int[] inputArray)
        {
            int length = inputArray.Length;
            int temp;
            for (int i = 0; i < length; i++)
            {
                temp = inputArray[i];
                while (i > 0 && inputArray[i - 1] >= temp)
                {
                    inputArray[i] = inputArray[i - 1];
                    i--;
                }
            }
            foreach (int i in inputArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
