using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysExcercise
{
    class StringReverse
    {
        public string reverse(string valueToReverse)
        {
            int stringLength = valueToReverse.Length;
            char[] arr = new char[stringLength];

            
            for(int i = 0; i < stringLength; i++)
            {
                arr[i] = valueToReverse[stringLength - 1 - i];

            }

            return new string(arr);

        }
    }
}
