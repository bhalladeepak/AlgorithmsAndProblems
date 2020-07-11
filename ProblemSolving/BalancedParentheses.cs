using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class BalancedParentheses
    {
        private static readonly char[] OpenParentheses = {'(', '[', '{'};
        private static readonly char[] CloseParentheses = {')', ']', '}'};

        public static bool ValidateString(string input)
        {
            Stack<int> parentheses = new Stack<int>();

            foreach (char chr in input )
            {
                int index;

                if ((index = Array.IndexOf(OpenParentheses, chr)) != -1)
                {
                    parentheses.Push(index);
                }
                else if ((index = Array.IndexOf(CloseParentheses, chr)) != -1)
                {
                    if (parentheses.Count == 0 || parentheses.Pop() != index)
                    {
                        return false;
                    }
                }
            }

            return parentheses.Count == 0;
        }

    }
}
