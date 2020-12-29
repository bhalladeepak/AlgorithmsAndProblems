using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;

namespace ProblemSolving
{
    public static class ArithmeticExpressionEvalution
    {
        /*
         //https://www.geeksforgeeks.org/arithmetic-expression-evalution/?ref=lbp
         There are 3 levels of precedence for 5 binary operators as given below:
            Highest: Exponentiation (^)
            Next highest: Multiplication (*) and division (/)
            Lowest: Addition (+) and Subtraction (-) 
        */

        public static void PrintEvaluateExpression()
        {
            string postFixExp = "24+46+*";
            PostfixExpression(postFixExp);


            string preFixExp = "-+8/632"; //Ans : 8
            PostfixExpression(preFixExp);
        }




        /*
         https://www.geeksforgeeks.org/evaluation-prefix-expressions/
         Polish notation (prefix notation) – It refers to the notation in which the operator is placed before its two operands .
         Here no parentheses are required, i.e.,
            +AB 

        EVALUATE_PREFIX(STRING)
            Step 1: Put a pointer P at the end of the end
            Step 2: If character at P is an operand push it to Stack
            Step 3: If the character at P is an operator pop two 
                    elements from the Stack. Operate on these elements
                    according to the operator, and push the result 
                    back to the Stack
            Step 4: Decrement P by 1 and go to Step 2 as long as there
                    are characters left to be scanned in the expression.
            Step 5: The Result is stored at the top of the Stack, 
                    return it
            Step 6: End
        */
        private static void PrefixExpression(string exp)
        {
            int a, b, ans, finalAns;
            Stack<int> st = new Stack<int>();

            for (int i = exp.Length; i == 0; i--)
            {
                string str = exp.Substring(i, 1);

                switch (str)
                {
                    case "/":
                    {
                        a = Convert.ToInt32(st.Pop());
                        b = Convert.ToInt32(st.Pop());
                        ans = a / b;
                        st.Push(ans);
                            break;
                    }
                    case "*":
                    {
                        a = Convert.ToInt32(st.Pop());
                        b = Convert.ToInt32(st.Pop());
                        ans = a * b;
                        st.Push(ans);
                            break;
                    }
                    case "+":
                    {
                        a = Convert.ToInt32(st.Pop());
                        b = Convert.ToInt32(st.Pop());
                        ans = a + b;
                        st.Push(ans);
                            break;
                    }
                    case "-":
                    {
                        a = Convert.ToInt32(st.Pop());
                        b = Convert.ToInt32(st.Pop());
                        ans = a - b;
                        st.Push(ans);
                            break;
                    }
                    default:
                    {
                        st.Push(Convert.ToInt32(str));
                        break;
                    }
                }
            }
            finalAns = st.Pop();

            Console.WriteLine();
            Console.WriteLine($"Pre-Fix Expression :  {exp}");
            Console.WriteLine($"Pre-Fix Result : {finalAns}");

        }




        /*
         https://www.geeksforgeeks.org/stack-set-4-evaluation-postfix-expression/?ref=leftbar-rightbar
         Reverse Polish notation(postfix notation) – It refers to the analogous notation in which the operator is placed after its two operands. 
         Again, no parentheses is required in Reverse Polish notation, i.e.,
            AB+ 

            The procedure for getting the result is:

            1. Convert the expression in Reverse Polish notation( post-fix notation).
            2. Push the operands into the stack in the order they are appear.
            3. When any operator encounter then pop two topmost operands for executing the operation.
            4. After execution push the result obtained into the stack.
            5. After the complete execution of expression the final result remains on the top of the stack.
        */

        private static void PostfixExpression(string exp)
        {
            Stack st = new Stack();
            int a, b, ans;
            for (int i = 0; i < exp.Length; i++)
            {
                string str = exp.Substring(i, 1);

                if (str == "/")
                {
                    a = Convert.ToInt32(st.Pop());
                    b = Convert.ToInt32(st.Pop());
                    ans = a / b;
                    st.Push(ans.ToString());
                }
                else if(str == "*")
                {
                    a = Convert.ToInt32(st.Pop());
                    b = Convert.ToInt32(st.Pop());
                    ans = a * b;
                    st.Push(ans.ToString());
                }
                else if (str == "+")
                {
                    a = Convert.ToInt32(st.Pop());
                    b = Convert.ToInt32(st.Pop());
                    ans = a + b;
                    st.Push(ans.ToString());
                }
                else if (str == "-")
                {
                    a = Convert.ToInt32(st.Pop());
                    b = Convert.ToInt32(st.Pop());
                    ans = a - b;
                    st.Push(ans.ToString());
                }
                else
                {
                    st.Push(str);
                }

            }

            string finalAns = (string) st.Pop();
            Console.WriteLine();
            Console.WriteLine($"Post-Fix Expression :  {exp}");
            Console.WriteLine($"Post-Fix Result : {finalAns}");

        }
    }
}
