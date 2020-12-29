using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArrayProblems
{
    /*
     https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/pairs-having-similar-element-eed098aa/
    A1 : 1
    A2 : 2
    A3 : 3
    A4 : 4

    Pairs : (A1,A2) (A2,A3) (A3,A4) (A1,A3) (A2,A4) (A1,A4)
     */
    public static class PairsHavingSimilarElements
    {
        public static int CountNoOfPairs(int[] A)
        {
            /*
             *
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var s = A[i] + 1;
                var m = A[i] - 1;

                for (int j = i; j < A.Length; j++)
                {
                    if (A[j] == s)
                    {
                        Console.WriteLine("({0},{1})", i + 1, j + 1);
                        count++;
                    }

                    if (A[j] == m)
                    {
                        Console.WriteLine("({0},{1})", i + 1, j + 1);
                        count++;
                    }
                }
            }
            */


            Array.Sort(A);
            int ans = 0;
            int arrayLength = A.Length;
            for (int i = 1; i < arrayLength; i++)
            {
                int cnt = 1;
                int st = 1;
                while (i < arrayLength && ((A[i] == A[i - 1]) || (A[i] == A[i - 1] + 1)))
                {
                    st++;
                    if (A[i] == A[i - 1])
                    {
                        cnt++;
                    }
                    i++;
                }

                if (st != 1 && st != cnt)
                {
                    ans += (st * (st - 1)) / 2;
                }

            }
            
            Console.WriteLine("Numbers of Pairs" + ans);
            return ans;


        }
    }
}
