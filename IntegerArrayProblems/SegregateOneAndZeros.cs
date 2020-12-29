using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    class SegregateOneAndZeros
    {
        //Time Complexity: O(n)
        public static int[] Segregate(int[] inputArray)
        {
            int length = inputArray.Length;
            int left = 0, right = length - 1;
            //int OneCount = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    if (inputArray[i] == 1)
            //        OneCount++;
            //}
            while (left < right)
            {
                /* Increment left index while we see 0 at left */
                while (inputArray[left] == 0 && left < right)
                    left++;
                /* Decrement right index while we see 1 at right */
                while (inputArray[right] == 1 && left < right)
                    right--;
                /* If left is smaller than right then there is a 1 at left and a 0 at right.  Exchange it */
                if (left < right)
                {
                    inputArray[left] = 0;
                    inputArray[right] = 1;
                    left++;
                    right--;
                }
            }
            return inputArray;
        }
      

    }
}
