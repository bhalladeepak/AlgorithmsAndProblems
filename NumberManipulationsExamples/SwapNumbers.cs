using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulationsExamples
{
    public class SwapNumbers
    {
        public void Swap()
        {
            int num1 = 104;
            int num2 = 107;

            Console.WriteLine("Vaues before swapping Num1, Num2 :" + num1 + ", " + num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

           Console.WriteLine("Vaues after swapping Num1, Num2 :" + num1 + ", " + num2);
        }
    }
}
