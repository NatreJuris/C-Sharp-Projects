using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else
                return false;
            Console.WriteLine();
            Console.ReadLine();
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.Id.Equals(emp.Id);
        }
    }
}
