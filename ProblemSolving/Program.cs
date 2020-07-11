using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            //print fizz if multiple of 3, print buzz if multiple of 5 or else print fizzbuzz if multiple of both 3 and 5
            //FizzBuzz.PrintFizzBuzz();

            //Parentheses balance checke example
            Console.WriteLine(BalancedParentheses.ValidateString("[{]"));


            Console.WriteLine(Palindrome.CheckPalindromeWithStack("xyz"));

            int angel = CalculateAngele.GetAngel(3.00, 30.00);
            Console.WriteLine(angel);
            Console.ReadLine();
        }
    }
}
