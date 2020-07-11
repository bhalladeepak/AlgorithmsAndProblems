using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {


            //foreach (string volume in Enum.GetNames(typeof(Gender)))
            //{
            //    Console.WriteLine("Volume Member: {0}\n Value: {1}",
            //        volume, (short)Enum.Parse(typeof(Gender), volume));
            //}
            Console.WriteLine((short)(Gender.Female));


            ExtensionMethodsHelpers extensionHelper = new ExtensionMethodsHelpers();
            extensionHelper.CallExtensionMethod();



            Console.ReadLine();
        }
    }
}
