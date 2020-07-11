using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    interface IFactory
    {
        void details();
    }

    // 'ConcreteProduct' class
    class PermanentEmployee : IFactory
    {
        public void details()
        {
            Console.WriteLine("This is permanent employee type object");
        }
    }
    // 'ConcreteProduct' class
    class TemporaryEmployee : IFactory
    {
        public void details()
        {
            Console.WriteLine("This is Temporary employee type object");
        }
    }
    // 'Creator' abstract class
    abstract class EmployeeFactory
    {
        public abstract IFactory Factory(string employeeType);
    }
    // 'ConcrteCreator' class
    class ConcreteEmployeeFactory : EmployeeFactory
    {
        public override IFactory Factory(string employeeType)
        {
            switch (employeeType)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new TemporaryEmployee();
                default:
                    throw new ApplicationException(string.Format("This type of employee can not be created"));
            }
        }
    }

    // factory method design pattern demo
    // calling class/ client

    class FactoryPattern
    {

    }
}
