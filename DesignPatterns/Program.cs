using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Decorator Example");
            DecoratorPattern.DecoratorExample();
            Console.WriteLine("Decorator Example Finished");

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Adapter Example");
            AdapterPattern.AdapterExample();
            Console.WriteLine("Adapter Example Finished");



            Console.WriteLine("Factory Example");
            EmployeeFactory EmployeeFactory = new ConcreteEmployeeFactory();

            IFactory permanentEmployee = EmployeeFactory.Factory("PermanentEmployee");
            permanentEmployee.details();

            IFactory TemporaryEmployee = EmployeeFactory.Factory("TemporaryEmployee");
            TemporaryEmployee.details();
            Console.WriteLine("Factory Example Finished");
            Console.Read();
        }
    }
}
