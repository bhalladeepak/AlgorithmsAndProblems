using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    class Program
    {
        //https://javarevisited.blogspot.com/2015/06/top-20-array-interview-questions-and-answers.html
        static void Main(string[] args)
        {
            PairOfSum.PairOfSumHelpers();

            Console.WriteLine();
            //---------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Pairs Having Similar Elements");
            PairsHavingSimilarElements.CountNoOfPairs(new int[] {1, 3, 5, 7, 8, 2, 5, 7});
            //---------------------------------------------------------------------------------------------------------------------//



            //int[] array = new int[] {1,2,3,4,4,3,5,10,7};
            //int numberOfWays = CutTheTree.NoOfWaysToCutTree(array);
            //Console.WriteLine(string.Format("Number of ways to cut the tree: {0}", numberOfWays));



            //---------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Find number of distinct values in the Array");
            int[] inputArray = new int[] { 2, 2, 2, 2 };
            var numberOfDistict = DistinctValuesInArray.FindNoOfDistinctValuesWithSort(inputArray);
            Console.WriteLine("largest int value = {0}", numberOfDistict);
            //---------------------------------------------------------------------------------------------------------------------//



            //---------------------------------------------------------------------------------------------------------------------//
            int[] firstArray = new[] { 1, 2, 5 };
            int[] seconeArray = new[] { 5, 7, 8, 5, 9 };
            int[] mergeArray = MergeIntArrays.Merge(firstArray, seconeArray);

            for (int i = 0; i < mergeArray.Length; i++)
            {
                Console.Write(mergeArray[i]);
            }

            //---------------------------------------------------------------------------------------------------------------------//



            //---------------------------------------------------------------------------------------------------------------------//
            //Console.WriteLine("Find the largest in the Array");
            //int[] inputArray = new int[] {1,2,3,2,30,2,5,20};
            //var largest = FindLargestAndSmallestInArray.FindLargest(inputArray);
            //Console.WriteLine("largest int value = {0}",largest);

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Find the minimum in Rotated Sorted Array");
            FindMinRotateArray.PrintMin();
            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Rotate a matrix by 90 degree in clockwise direction without using any extra space");
            Matrix.Rotate();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Max Sum Contiguous Subarray");
            MaxSumContiguousSubarray.PrintSum();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Spiral Order Matrix : Print a given matrix in spiral form");
            SpiralOrderMatrix.SprialPrint();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Repeat and Missing Number Array");
            RepeatMissingNumber.Print();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Max Distance in an Array");
            MaxIndexDistance.PrintMaxDistance();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Find Duplicate in Array");
            DuplicateInArray.PrintDuplicate();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Find Majority Element in the Array");
            MajorityElementOfArray.PrintMajority();

            //---------------------------------------------------------------------------------------------------------------------//
            Console.ReadLine();
        }
    }
}
