using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysExcercise
{
    class Program
    {
        static int Main(string[] args)
        {
      
            int[] intArray = new int[]{1,3,4,5,7,4,64,5,7,9,20};
            int valueToCheck = 27;

            //CheckSumInAnArray arrayCheck = new CheckSumInAnArray();
            //return arrayCheck.CheckValueInAnArray(intArray, valueToCheck);

            //////////////////////////////////////////////////////////////

            //string valueToReverse = "This is an array";
            //StringReverse stringReverseObj = new StringReverse();
            //string reverseValue = stringReverseObj.reverse(valueToReverse);

            //Console.WriteLine("{0}", reverseValue);
            //Console.ReadLine();
            //Console.ReadLine();



            /////////////////////////////////////////////////
            FindSum2 findSum = new FindSum2();
            findSum.CheckSum2(intArray, valueToCheck);
            Console.ReadLine();
            Console.ReadLine();
            return 0;

        }
        
    }
}
