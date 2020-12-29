using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    public static class Matrix
    {
        //Given a square matrix, turn it by 90 degrees in clockwise direction without using any extra space.
        //https://www.geeksforgeeks.org/rotate-a-matrix-by-90-degree-in-clockwise-direction-without-using-any-extra-space/


        public static void Rotate()
        {
            Rotate90Clockwise();

            Rotate90AntiClockwise();
        }

        public static void Rotate90Clockwise()
        {
            int[,] arr = {{1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}};

            Console.WriteLine("Original Matrix");
            PrintMatrix(arr);
            RotateClockwise(arr);
            Console.WriteLine("Rotated Matrix Clockwise");
            PrintMatrix(arr);
        }
        
        private static int[,] RotateClockwise(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n/2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = a[i, j];

                    a[i, j] = a[n - 1 - j, i];
                    a[n - 1 - j, i] = a[n - 1 - i, n - 1 - j];
                    a[n - 1 - i, n - 1 - j] = a[j, n - 1 - i];
                    a[j, n - 1 - i] = temp;
                }
            }

            return a;
        }


        public static void Rotate90AntiClockwise()
        {
            int[,] arr = {{1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}};

            Console.WriteLine("Original Matrix");
            PrintMatrix(arr);
            RotateAntiClockwise(arr);
            Console.WriteLine("Rotated Matrix AntiClockwise");
            PrintMatrix(arr);

        }

        private static int[,] RotateAntiClockwise(int[,] a)
        {
            int n = a.GetLength(0);

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = a[i, j];
                    
                    a[i, j] = a[j, n - 1 - i];
                    a[j, n - 1 - i] = a[n - 1 - i, n - 1 - j];
                    a[n - 1 - i, n - 1 - j] = a[n - 1 - j, i];
                    a[n - 1 - j, i] = temp;
                }
            }

            return a;
        }

        private static void PrintMatrix(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
