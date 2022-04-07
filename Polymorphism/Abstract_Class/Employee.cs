using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
     
        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + lastName);
            Console.ReadLine();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("Looks like" + firstName + lastName + " has had enouph of this place and has quit.");
            Console.ReadLine();
        }

    }
}
