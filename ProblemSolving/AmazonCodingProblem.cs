using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class AmazonCodingProblem
    {
        public static void Execute()
        {
            //Console.WriteLine(minimumCoinFlips("HHTHTT"));
            Console.WriteLine(minimumCoinFlips("TTTTT"));
        }

        public static int minimumCoinFlips(string coins)
        {

            int tails = 0;

            int flips = 0;


            foreach (char ch in coins.ToCharArray())
            {
                if (ch == 'T') tails++;

                if (ch == 'H') flips++;

                flips = Math.Min(flips, tails);

            }
            return flips;

        }



    }
}
