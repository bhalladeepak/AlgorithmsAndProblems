using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    //http://sanjaysainitech.blogspot.com/2007/06/difference-between-destructor-dispose.html
    public class DestructorExample : IDisposable
    {
        public DestructorExample()
        {
            Console.WriteLine("Base class constructor");
        }
        ~DestructorExample()
        {
            Console.WriteLine("Base class destructor");
        }

        public void Dispose()
        {
            Console.WriteLine("Base class dispose");

            //A Dispose method should call the GC.SuppressFinalize method for the object it is disposing if the class has desturctor because it has already done the work to clean up the object.
            //Below line will avoid calling the Destructor
            GC.SuppressFinalize(this);
        }

    }

    public class DerivedClass : DestructorExample
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived Class constructor");
        }
        ~DerivedClass()
        {
            Console.WriteLine("Derived class destructor");
        }

    }
}
