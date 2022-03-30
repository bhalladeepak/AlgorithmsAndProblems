using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepCopy
{
    //For Source Code
    //https://www.c-sharpcorner.com/UploadFile/ff2f08/deep-copy-of-object-in-C-Sharp/

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeId = 1000;
            emp.EmployeeName = "Jignesh";
            emp.Department = new Department { DepartmentId = 1, DepartmentName = "Examination" };

            Employee empClone = emp.Clone() as Employee;

            Employee emp1 = emp;

            int empHashCode = emp.GetHashCode();
            int cloneHashCode = empClone.GetHashCode();
            int emp1HAshCode = emp1.GetHashCode();

            Employee empClone1Utility = Utility.CloneObject(emp) as Employee;
            Employee empClone2 = emp.CloneObject() as Employee;

            Employee empCloneExtensionSerial = emp.CopyObject<Employee>();
            empCloneExtensionSerial.EmployeeName = "Updatede Serial";
            
            
            //now Change Original Object Value
            emp.EmployeeName = "Tejas";
            emp.Department.DepartmentName = "Admin";

            //Print origianl as well as clone object properties value.

            Console.WriteLine("Original Employee Name : " + emp.EmployeeName);
            Console.WriteLine("Original Department Name : " + emp.Department.DepartmentName);

            Console.WriteLine("");

            Console.WriteLine("Clone Object Employee Name (Clone Method) : " + empClone.EmployeeName);
            Console.WriteLine("Clone Object Department Name (Clone Method) : " + empClone.Department.DepartmentName);

            Console.WriteLine("");

            Console.WriteLine("Clone Object Employee Name (Utility Method) : " + empClone1Utility.EmployeeName);
            Console.WriteLine("Clone Object Department Name (Utility Method) : " + empClone1Utility.Department.DepartmentName);

            Console.WriteLine("");

            Console.WriteLine("Clone Object Employee Name (Extension Method) : " + empClone2.EmployeeName);
            Console.WriteLine("Clone Object Department Name (Extension Method) : " + empClone2.Department.DepartmentName);

            Console.WriteLine("");
            Console.WriteLine("EXTENSION SERIALIZATION");
            Console.WriteLine("Clone Name : " + empCloneExtensionSerial.EmployeeName);
            Console.WriteLine("Original Name : " + emp.EmployeeName);

            Console.ReadKey();

            
        }
    }
}
