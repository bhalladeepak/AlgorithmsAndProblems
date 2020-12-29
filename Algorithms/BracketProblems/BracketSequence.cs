using System;
using System.Collections.Generic;
using System.Text;

namespace BracketProblems
{
    /*A bracket sequence is a string that contains only characters '(' and ')'.
    https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/bracket-sequence-1-40eab940/description/
    https://www.hackerearth.com/submission/44290695/
    A correct bracket sequence is a bracket sequence that can be transformed into a correct arithmetic expression by inserting characters 
    '1' and '+' between the original characters of the sequence. For example, bracket sequences '()()' and '(())' are correct. 
    The resulting expressions of these sequences are: '(1)+(1)' and '((1+1)+1)'. However, '(', ')(', and '(' are incorrect bracket sequences. 

    You are given a bracket sequence , where  denotes the type of 's bracket (open or close). It is not mandatory that  is necessarily correct. 
    Your task is to determine the number of 's such that  is a correct bracket sequence.

    Input format : The single line contains sequence .
    Output format : Print the number of shifts denoting the correct bracket sequence.
    Constraints : |s| <= 5 * 10^5
*/
    public static class BracketSequence
    {
        public static void PrintBracketSequence()
        {
            //string input = ")()()(";  //3
            //string input = "))()((";
            string input = "(()))("; //4
            Console.WriteLine($"Shifting Bracket Sequence : {input}");
            
            int seq = CheckSequence(input);
            Console.WriteLine($"Number of Sequence : {seq}");
        }
        private static int CheckSequence(string input)
        {
            char[] charArr = input.ToCharArray();
            int bal = 0, count = 0, min = 5;

            // Odd length string can never be balanced
            if (charArr.Length % 2 == 1)
                return 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == ')')
                    bal--;
                else
                    bal++;
                
                if (min > bal)
                {
                    min = bal;
                    count = 0;
                }

                if (min == bal)
                    count++;
            }

            if (bal == 0)
                return (count);
            else
                return 0;

        }

        private static int CheckSequenceSecond(string input)
        {
            char[] a = input.ToCharArray();
            int bal = 0;
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                    bal++;
                else
                    bal--;

                if (bal == 0)
                    count++;
            }

            if (bal != 0)
                return 0;
            else
                return count;
        }
    }
}
