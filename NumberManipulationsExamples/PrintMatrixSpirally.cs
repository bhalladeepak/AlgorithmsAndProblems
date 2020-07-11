using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public class PrintMatrixSpirally
    {
        public void PrintMatrix(int[,] matrix)
        {
            if (matrix.Length == 0)
                return;

            int top = 0;
            int down = matrix.GetLength(0) - 1;
            int left = 0;
            int right = matrix.GetLength(1) - 1;

            while (true)
            {
                // Print top row
                for (int j = left; j <= right; ++j)
                    Console.WriteLine(matrix[top,j] + " ");
                top++;
                if (top > down || left > right) 
                    break;

                //Print the rightmost column
                for (int i = top; i <= down; ++i)
                    Console.WriteLine(matrix[i,right] + " ");
                right--;
                if (top > down || left > right) 
                    break;

                //Print the bottom row
                for (int j = right; j >= left; --j)
                    Console.WriteLine(matrix[down,j] + " ");
                down--;
                if (top > down || left > right) 
                    break;

                //Print the leftmost column
                for (int i = down; i >= top; --i)
                    Console.WriteLine(matrix[i,left] + " ");
                left++;
                if (top > down || left > right) 
                    break;
            }
        }

    }

}

