using System;
using System.Collections.Generic;
using System.Text;

namespace BracketProblems
{
    public static class RedundantBracket
    {
        /*
        Expression contains redundant bracket or not
        https://www.interviewbit.com/problems/redundant-braces/
        https://www.geeksforgeeks.org/expression-contains-redundant-bracket-not/
        
        Explanation:
          1. ((a+b)) can reduced to (a+b), this Redundant
          2. (a+(b)/c) can reduced to (a+b/c) because b is surrounded by () which is redundant.
          3. (a+b*(c-d)) doesn't have any redundant or multiple brackets.
          4. (a + (a + b)) doesn't have any redundant or multiple brackets.
        */


        public static void PrintIsRedundant()
        {
            string exp = "((a+b))";

            Console.WriteLine("Redundant Bracket");
            Console.WriteLine(exp);
            bool isRedundant = IsRedundantBracket(exp);

            Console.WriteLine($"Redundant : {isRedundant}");
        }

        private static bool IsRedundantBracket(string exp)
        {
            char[] a = exp.ToCharArray();
            Stack<char> st = new Stack<char>();
            
            for (int i = 0; i < a.Length; i++)
            {
                //pull all the chars until first closing bracket 
                if (a[i] != ')')
                    st.Push(a[i]);

                // If immediate pop have open parenthesis '(' duplicate brackets found  
                bool isRedundant = true;

                if (a[i] == ')')
                {
                    char top = st.Pop();
                    while (top != '(')
                    {
                        // Check for operators in expression 
                        if (top == '*' || top == '+' || top == '/' || top == '-')
                            isRedundant = false;

                        top = st.Pop();
                    }

                    if (isRedundant == true)
                        return isRedundant;
                }
            }
            return false;
        }
    }
}
