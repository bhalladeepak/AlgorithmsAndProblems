using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    public enum Gender : short
    {
        Male = 1,
        Female = 2,
        Unknown = 3
    }

    public static class EnumExtensions
    {

    }

    public class OriginalClass
    {
        public void Display()
        {
            Console.WriteLine("I am in display method of original class");
        }

        public void Print()
        {
            Console.WriteLine("I am in Print  of original class");
        }
    }

    public static class ExtensionOfOriginalClass
    {
        public static void NewExtensionMethod(this OriginalClass originalClass)
        {
            Console.WriteLine("I am in extension method");
        }
    }
    public class ExtensionMethodsHelpers
    {
        public void CallExtensionMethod()
        {

            OriginalClass orgClass = new OriginalClass();
            orgClass.Display();
            orgClass.Print();
            orgClass.NewExtensionMethod();

        }
    }
}
