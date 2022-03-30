using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class AmazonCodingProblemSecond
    {

        public static void Execute()
        {
            String str = "abc";

            Console.Write(countSub(str));
        }

        static int countSub(String str)
        {
            int n = (int)str.Length;

            // Stores the count of
            // subStrings
            int ans = 0;

            // Stores the frequency
            // of characters
            int[] cnt = new int[26];

            // Initialised both pointers
            // to beginning of the String
            int i = 0, j = 0;

            while (i < n)
            {

                // If all characters in
                // subString from index i
                // to j are distinct
                if (j < n &&
                   (cnt[str[j] - 'a'] == 0))
                {

                    // Increment count of j-th
                    // character
                    cnt[str[j] - 'a']++;

                    // Add all subString ending
                    // at j and starting at any
                    // index between i and j
                    // to the answer
                    ans += (j - i + 1);

                    // Increment 2nd pointer
                    j++;
                }

                // If some characters are repeated
                // or j pointer has reached to end
                else
                {

                    // Decrement count of j-th
                    // character
                    cnt[str[i] - 'a']--;

                    // Increment first pointer
                    i++;
                }
            }

            // Return the final
            // count of subStrings
            return ans;
        }




    }
}
