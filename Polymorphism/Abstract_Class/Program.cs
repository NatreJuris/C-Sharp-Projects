using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { firstName = " Sample ", lastName = "Student" };

            emp.SayName();

            Person emp1 = new Employee()
            {

            };
            emp.Quit(emp);
        }
    }
}
