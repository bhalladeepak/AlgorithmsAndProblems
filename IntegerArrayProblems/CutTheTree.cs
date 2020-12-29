using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{

    /*There are N trees growing along a street. For safety reasons, one of the trees needs to be cut down. The local council wants the street to look ordered, so all the
     * remaining trees should be shorted in non-descending order of height. Your goal is to count the number of ways this can be done.
     *
     * Write a function that, given an array inputArray consisting of N integers, where inputArray[K] denotes the height of hte K-th tree, returns the number of trees you
     * can cut to satisfy the above condition. If the condition cannot be satisfied, your function should return 0.
     *
     * Example:
     *1. Given inputArray=[3,4,5,4] your function should return 2. You can cut down the tree of height 5 or second tree of height 4
     *2. Given inputArray=[4,5,2,3,4] your function should return 0. After cutting down any of these trees, the rest of the trees will not be ordered by height
     *3. Given inputArray=[1,2,3,3,5,6,7] your function should return 7. You can cut any of the trees
     *
     */
    public class CutTheTree
    {
        public static int NoOfWaysToCutTree(int[] inputArray)
        {
            int noOfWays = 0;
            int arrayLength = inputArray.Length;

            if (arrayLength == 0) return 0;

            for (int i = 1; i < arrayLength; i++)
            {
                if (inputArray[i - 1] > inputArray[i])
                {
                    if (noOfWays != 0) return 0;
                    if (i == 1 || inputArray[i - 2] <= inputArray[i]) ++noOfWays;
                    if (i == arrayLength - 1 || inputArray[i - 1] <= inputArray[i + 1]) ++noOfWays;
                    if (noOfWays == 0) return 0;
                }
            }

            return noOfWays == 0 ? arrayLength : noOfWays;

        }
    }
}
