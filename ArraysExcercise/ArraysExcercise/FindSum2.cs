using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysExcercise
{
    class FindSum2
    {
        public Boolean CheckSum2(int [] arr, int sum)
        {
            if (arr.Length == 0)
            {
                Console.Write("No Sum");
                return false;
            }

            Array.Sort(arr);
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                int temp = arr[i] + arr[j];
                if (temp == sum)
                {
                    Console.Write(arr[i] + "+" + arr[j] + "=" + sum);
                    return true;
                }
                else if (temp > sum)
                {
                    j--;
                }
                else
                {
                    i++;
                }

            }
            Console.Write("No Sum");
            return false;
        }
    }
}
