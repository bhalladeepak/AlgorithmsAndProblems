using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class FizzBuzz
    {
        public static void PrintFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " : fizzbuzz");
                else
                {
                    if (i % 3 == 0)
                        Console.WriteLine(i + " : fizz");
                    if (i % 5 == 0)
                        Console.WriteLine(i + " : buzz");
                }
            }
            Console.ReadKey();
        }
    }
}
