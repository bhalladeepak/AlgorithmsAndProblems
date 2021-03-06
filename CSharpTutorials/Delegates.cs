﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-functions
    public class Delegates
    {
        delegate void TestDelegate(string s);

        static void M(string s)
        {
            Console.WriteLine(s);
        }

        public static void DelegateDemo()
        {
            // Original delegate syntax required 
            // initialization with a named method.
            TestDelegate testDelA = new TestDelegate(M);

            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };


            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate testDelC = x => { Console.WriteLine(x); };

            //Invoking the delegates.
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");

        }

    }
}
