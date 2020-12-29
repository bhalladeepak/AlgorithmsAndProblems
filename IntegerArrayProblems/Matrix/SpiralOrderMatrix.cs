using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    /*
     * Print a given matrix in spiral form : Given a 2D array, print it in spiral form
     *Input:    1    2   3   4
                5    6   7   8
                9   10  11  12
                13  14  15  16
        Output: 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 
        Explanation: The output is matrix in spiral format.

    Algorithm:

    1. create and initilize variables k – starting row index, m – ending row index, l – starting column index, n – ending column index
    2. Run a loop until all the squares of loops are printed.
    3. In each outer loop traversal print the elements of a square in clockwise manner.
    4. Print the top row, i.e. Print the elements of kth row from column index l to n, and increase the count of k.
    5. Print the right column, i.e. Print the last column or n-1th column from row index k to m and decrease the count of n.
    6. Print the bottom row, i.e. if k > m, then print the elements of m-1th row from column n-1 to l and decrease the count of m
    7. Print the left column, i.e. if l < n, then print the elements of lth column from m-1th row to k and increase the count of l.
    //https://www.geeksforgeeks.org/print-a-given-matrix-in-spiral-form/
     */
    public static class SpiralOrderMatrix
    {
        public static void SprialPrint()
        {

            int[,] a =
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            //int[,] a =
            //{
            //    {1, 2, 3, 4, 5, 6},
            //    {7, 8, 9, 10, 11, 12},
            //    {13, 14, 15, 16, 17, 18}
            //};
            Print(a);

        }
        private static void Print(int[,] a)
        {

            int rLen = a.GetLength(0); //End row index
            int cLen = a.GetLength(1); //End column index

            int currentR = 0, currentC = 0, i = 0;


            while (currentR < rLen && currentC < cLen)
            {
                // Print the first row  
                // from the remaining rows 
                for (i = currentC; i < cLen; i++)
                    Console.Write(a[currentR, i] + " ");
                currentR++;

                // Print the last column from the 
                // remaining columns 
                for (i = currentR; i < rLen; i++)
                    Console.Write(a[i, cLen - 1] + " ");
                cLen--;


                if (currentR < rLen)
                {
                    for (i = cLen-1; i >= currentC; i--)
                        Console.Write(a[rLen-1, i] + " ");
                    rLen--;
                }

                if (currentC < cLen)
                {
                    for (i = rLen - 1; i >= currentR; i--)
                        Console.Write(a[i, currentC] + " ");
                    currentC++;
                }

            }


        }
    }
}
