using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    /*
     * Backtracking to find all subsets
     * 
     * 
     * There are 2^n decisions we have to make
     * At each step we are making a decision whether to include the current element in the set or not.
     */

    public static class FindAllArraySubsets
    {
        public static void Demo()
        {
            int[] inputArray = { 1, 2, 3 };
            int arrLength = inputArray.Length;
            PrintPowerSet(inputArray, arrLength);

        }

        private static void PrintPowerSet(int[] arr, int arrLength)
        {
            // Power set contains 2^N subsets.
            int powerSetCount = 1 << arrLength;


            for (int setMask = 0; setMask < powerSetCount; setMask++)
            {
                var s = new StringBuilder();
                for (int i = 0; i < arrLength; i++)
                {
                    // Checking whether i'th element of input collection should go to the current subset.
                    if ((setMask & (1 << i)) > 0)
                    {
                        s.Append(arr[i]);
                    }
                }
                Console.WriteLine(s);
            }
        }









    private static void PowerSet(IList<int> nums, ref IList<IList<int>> output)
    {
        // ToDo: validate args
        output.Add(new List<int>());
        ExpandSet(nums, 0, ref output);
    }

    private static void ExpandSet(IList<int> nums, int pos, ref IList<IList<int>> output)
    {
        if (pos == nums.Count)
        {
            return;
        }

        List<int> tmp;
        int item = nums[pos];

        for (int i = 0, n = output.Count; i < n; i++)
        {
            tmp = new List<int>();
            tmp.AddRange(output[i]);
            tmp.Add(item);
            output.Add(tmp);
        }

        ExpandSet(nums, pos + 1, ref output);
    }






        private static void PrintAllSubsets(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                PrintSubset(arr, i, 1);
            }

        }

        private static void PrintSubset(int[] arr, int startIndex, int len)
        {

            string sub = string.Empty;
            for (int j = 0; j < arr.Length; j++)
            {
                sub = $"{sub}{arr[j]}";
                Console.WriteLine(sub);
            }

        }
    }
}
