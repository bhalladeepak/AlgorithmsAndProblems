using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public class Segregate0and1
    {
        //Time Complexity: O(n)
        public void Segregate(int[] array)
        {
            int length = array.Length;
            int left = 0;
            int right = length - 1;

            while(left < right)
            {
                while (array[left] == 0 && left < right)
                    left++;

                while (array[right] == 1 && left < right)
                    right--;

                if(left < right)
                {
                    array[left] = 0;
                    array[right] = 1;
                    left++;
                    right--;
                }
            }
        }
    }
}
