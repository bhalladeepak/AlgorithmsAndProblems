using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    //https://www.geeksforgeeks.org/iterative-letter-combinations-of-a-phone-number/
    public class PhoneLetterCombinations
    {

        public static  void GetLetterCombinations()
        {
            string number = "234";

            IEnumerable<string> letters = LetterCombinations(number);
            foreach (var l in letters)
            {
                Console.Write(l + ", ");
            }
        }

        private static IEnumerable<string> LetterCombinations(string number)
        {
            string[] table = { "", "", "abc", "def", "ghi", "jki", "mno", "pqrs", "tuv", "wxyz" };
            int digLength = number.Length;

            List<string> returnList = new List<string>();
            Queue<string> q = new Queue<string>();
            int[] numArr = new int[digLength];

            //parse the input string into an int array
            for (int i = 0; i < number.Length; i++)
            {
                numArr[i] = int.Parse(number[i].ToString());
            }


            q.Enqueue("");
            
            //main logic
            while(q.Count != 0)
            {
                string dequeue = q.Dequeue();

                if (dequeue.Length == digLength)
                {
                    returnList.Add(dequeue);
                }
                else
                {
                    var dig = numArr[dequeue.Length];
                    String alphabets = table[dig];
                    foreach (char alpha in alphabets)
                    {
                        q.Enqueue(dequeue + alpha);
                    }
                }
            }

            return returnList;

        }
    }
}
