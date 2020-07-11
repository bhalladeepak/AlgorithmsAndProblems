using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseANumber objReverse = new ReverseANumber();
            //int reverse = objReverse.ReverseUsingMod(12304);
            //Console.WriteLine(reverse);
            //---------------------------------------------------------------------------------------------------------------------//

            //int reverse1 = objReverse.ReversWithoutMod(268);
            //Console.WriteLine(reverse1);
            //Console.ReadLine();
            //---------------------------------------------------------------------------------------------------------------------//

            //FibonacciSeries.Fibonacci_Iterative(9);
            //Console.ReadLine();
            //---------------------------------------------------------------------------------------------------------------------//

            //FibonacciSeries.Fibonacci_Recursive(9);
            //Console.ReadLine();
            //---------------------------------------------------------------------------------------------------------------------//

            //SwapNumbers swap = new SwapNumbers();
            //swap.Swap();
            //---------------------------------------------------------------------------------------------------------------------//

            //Palindrome objPalindrome = new Palindrome();
            //objPalindrome.CheckPalindrome(151);
            //---------------------------------------------------------------------------------------------------------------------//

            //int[,] matrix = new int[4,4]{{2,3,4,5},{1,43,5,8},{0,3,6,5},{0,3,4,7}};
            //PrintMatrixSpirally printMatrix = new PrintMatrixSpirally();
            //printMatrix.PrintMatrix(matrix);
            //---------------------------------------------------------------------------------------------------------------------//

            /*
            int[] firstArray = new[] {1, 2, 5};
            int[] seconeArray = new[] {5,7,8,5,9};
            int[] mergeArray = Arrays.Merge(firstArray, seconeArray);

            for (int i = 0; i < mergeArray.Length; i++)
            {
                Console.Write(mergeArray[i]);
            }
            Console.ReadLine();
            */

            /*
            int[] zeroOneArray = new[] {1, 0, 1, 0, 0, 0, 1};
            int[] sortedArray = Arrays.SegragateOneAndZeros(zeroOneArray);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i]  + " ");
            }
            Console.ReadLine();
            */

            //---------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("Nuclear Rods Cost Example!");
            int minCost = NuclearRods.minimalCost(4, new string[] { "1 2", "1 4" });
            Console.WriteLine(string.Format("Minimal Cost is: {0}", minCost));
            //---------------------------------------------------------------------------------------------------------------------//
            Console.ReadLine();

        }
    }
}
