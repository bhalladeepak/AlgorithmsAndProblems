using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BracketProblems
{
    /*
     * A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

        S is empty;
        S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
        S has the form "VW" where V and W are properly nested strings.
        For example, the string "{[()()]}" is properly nested but "([)()]" is not.

        Write a function:
        class Solution { public int solution(string S); }

        that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

        For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..200,000];
        string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
 */


    public static class BalancedParentheses
    {
        private static readonly char[] OpenParentheses = { '(', '[', '{' };
        private static readonly char[] CloseParentheses = { ')', ']', '}' };

        public static void PrintParenthesesBalance()
        {
            //Input: exp = “[()]{ }{[()()]()}”
            //Output: Balanced

            //Input: exp = “[(])”
            //Output: Not Balanced

            //Input: exp = “(())”
            //Output: Not Balanced

            string exp = "(()())";

            Console.WriteLine("Balanced Parentheses");
            Console.WriteLine(exp);
            bool isBalance = CheckParenthesesUsingDict(exp);

            Console.WriteLine($"Balanced : {isBalance}");

        }

        private static bool CheckParenthesesUsingArray(string input)
        {
            Stack<int> parentheses = new Stack<int>();

            foreach (char chr in input)
            {
                int openIndex = Array.IndexOf(OpenParentheses, chr);
                int closeIndex = Array.IndexOf(CloseParentheses, chr);

                //if the parentheses is found
                if (openIndex != -1)
                {
                    parentheses.Push(openIndex);
                }
                else if (closeIndex != -1)
                {
                    if (parentheses.Count == 0 || parentheses.Pop() != closeIndex)
                    {
                        return false;
                    }
                }
            }

            return parentheses.Count == 0;
        }

        private static bool CheckParenthesesUsingDict(string input)
        {
            char[] a = input.ToCharArray();
            Stack<int> balanceParan = new Stack<int>();
            Dictionary<char, int> openParan = new Dictionary<char, int>();
            Dictionary<char, int> closeParan = new Dictionary<char, int>();

            openParan.Add('(', 1);
            openParan.Add('[', 2);
            openParan.Add('{', 3);

            closeParan.Add(')', 1);
            closeParan.Add(']', 2);
            closeParan.Add('}', 3);

            for (int i = 0; i < a.Length; i++)
            {
                if (openParan.ContainsKey(a[i]))
                    balanceParan.Push(openParan[a[i]]);

                if (closeParan.ContainsKey(a[i]) || balanceParan.Count == 0)
                {
                    if (closeParan[a[i]] != balanceParan.Pop())
                        return false;
                }
            }

            return balanceParan.Count == 0;
        }

        public static int Solution(string S)
        {
            Stack<int> parenthesis = new Stack<int>();

            foreach (char c in S)
            {
                int openIndex = Array.IndexOf(OpenParentheses, c);
                int closeIndex = Array.IndexOf(CloseParentheses, c);
                if (openIndex != -1)
                {
                    parenthesis.Push(openIndex);
                }
                else if (closeIndex != -1)
                {
                    if (parenthesis.Count == 0 || parenthesis.Pop() != closeIndex)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
