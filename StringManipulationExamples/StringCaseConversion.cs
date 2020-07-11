using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    public class StringCaseConversion
    {
        public string ConvertToUpperCase(string inputValue)
        {
            StringBuilder output = new StringBuilder();
            for(int i=0; i<inputValue.Length; i++)
            {
                if (inputValue[i] >= 97 && inputValue[i] <= 122)
                    output.Append((char)(inputValue[i] - 32));
                else
                    output.Append(inputValue[i]);

            }
            return output.ToString();

        }
    }
}
