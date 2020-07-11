using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public class FirstRepeatedCharInString
    {
        ///Complexity: O(256) + O(n) + O(n) = O(n)

        public char RepeatedCharInString(string str)
        {
            int[] chars = new int[256];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                chars[str[i]]++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (chars[str[i]] > 1)
                {
                    return str[i];
                }
            }
            return ' ';
        }
    }
}
