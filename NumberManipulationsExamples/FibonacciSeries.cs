using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public static class FibonacciSeries
    {
        public static void Fibonacci_Iterative(int len)
        {
            int first = 0;
            int second = 1;
            int third = 0;

            Console.Write("{0} {1}", first, second);

            for (int i = 2; i < len; i++)
            {
                third = first + second;
                Console.Write(" {0} ", third);
                first = second;
                second = third;
            }
        }

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_temp(0, 1, 1, len);
        }

        private static void Fibonacci_temp(int first, int second, int count, int len)
        {
            if (count <= len)
            {
                Console.Write(" {0} ", first);
                Fibonacci_temp(second, first + second, count + 1, len);
            }
        }

        //Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }
    }
}
