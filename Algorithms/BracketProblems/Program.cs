using System;

namespace BracketProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parentheses balance check
            Console.WriteLine("");
            BalancedParentheses.PrintParenthesesBalance();

            //---------------------------------------------------------------------------------------------------------------------//

            //Redundant Bracket check
            Console.WriteLine("");
            RedundantBracket.PrintIsRedundant();

            //---------------------------------------------------------------------------------------------------------------------//

            //Shifting Bracket Sequence
            Console.WriteLine();
            BracketSequence.PrintBracketSequence();
            //---------------------------------------------------------------------------------------------------------------------//


            Console.ReadLine();
        }
    }
}
