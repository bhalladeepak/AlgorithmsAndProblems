using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace DeepCopy
{
    [Serializable]
    public class Employee : ICloneable, IEquatable<Employee>
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public Department Department { get; set; }

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }
                return null;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        public bool Equals(Employee other)
        {
            return other != null &&
                   EmployeeId == other.EmployeeId &&
                   EmployeeName == other.EmployeeName &&
                   EqualityComparer<Department>.Default.Equals(Department, other.Department);
        }

        public override int GetHashCode()
        {
            //int hashCode = 1601160773;
            //hashCode = hashCode * -1521134295 + EmployeeId.GetHashCode();
            //hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmployeeName);
            //hashCode = hashCode * -1521134295 + EqualityComparer<Department>.Default.GetHashCode(Department);
            //return hashCode;


            int hashCode = 0;
            hashCode = EmployeeId.GetHashCode();
            hashCode = EqualityComparer<string>.Default.GetHashCode(EmployeeName);
            hashCode = EqualityComparer<Department>.Default.GetHashCode(Department);
            return hashCode;
        }
    }
}
