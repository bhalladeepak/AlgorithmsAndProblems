using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {


            //DerivedClass deriveClassObj = new DerivedClass();

            //deriveClassObj.Dispose();
            

            B Myb = new D();
            D Myd = new D();

            Myb.Display();
            Myd.Display();

            Myb.DisplayNew();
            Myd.DisplayNew();

            Console.ReadLine();
        }
    }
}
