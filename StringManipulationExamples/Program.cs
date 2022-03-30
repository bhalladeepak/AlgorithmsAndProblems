using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "polop";
            string str2 = "hello";

            //FirstNonRepeatedCharInString nonRepeatedChar = new FirstNonRepeatedCharInString();
            //char nonRepeated = nonRepeatedChar.NonRepeatedCharInString("1aaddcc");
            //Console.WriteLine(nonRepeated);


            //FirstRepeatedCharInString repeatedChar = new FirstRepeatedCharInString();
            //char repeated = repeatedChar.RepeatedCharInString("1aaddcc");
            //Console.WriteLine(repeated);

            //StringCaseConversion conversion = new StringCaseConversion();
            //string upper = conversion.ConvertToUpperCase("deepak");
            //Console.WriteLine(upper);


            #region String Comparison

            bool compareResult = StringExercise.StringComparison(str1, str2);
            Console.WriteLine("Are both string same : " + compareResult);


            #endregion

            #region Remove duplicate characters from string

            string removeDuplicate = StringExercise.RemoveDuplicateChars(str1);
            Console.WriteLine("Original String : " + str1);
            Console.WriteLine("Result after removing duplicate chars : " + removeDuplicate);
            #endregion

            #region Find duplicate charactes in the string

            string duplicateChars = StringExercise.FindDuplicateChars(str1);
            Console.WriteLine("Original String : " + str1);
            Console.WriteLine("Duplicate chars : " + duplicateChars);

            #endregion


            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("Reverse a string in Place");
            ReverseAStringInPlace.ReverseString();

            //---------------------------------------------------------------------------------------------------------------------//
            

            Console.WriteLine("Reverse the String");
            ReverseString.PrintReverse();
            
            //---------------------------------------------------------------------------------------------------------------------//


            Console.WriteLine("");
            Console.WriteLine("SubString");
            CheckSubString.PrintSubStringIndex();

            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Add Binary Strings");
            AddBinaryString.PrintAddition();
            //---------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("");
            Console.WriteLine("Palindrome check");
            PalindromeCheck.CheckPalindrome();
            //---------------------------------------------------------------------------------------------------------------------//



            
            Console.ReadLine();
            
        }
    }
}
