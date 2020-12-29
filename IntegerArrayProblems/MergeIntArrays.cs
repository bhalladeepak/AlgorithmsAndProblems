using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    class MergeIntArrays
    {
        public static int[] Merge(int[] array1, int[] array2)
        {
            int newArraySize = array1.Count() + array2.Count();
            int[] mergeArray = new int[newArraySize];


            int i = 0, j = 0, k = 0;

            while (k < newArraySize)
            {
                if (j == array2.Length || ((i < array1.Length) && (array1[i] < array2[j])))
                {
                    mergeArray[k] = array1[i];
                    i++;
                }
                else
                {
                    mergeArray[k] = array2[j];
                    j++;
                }
                k++;
            }
            return mergeArray;
        }
    }
}
