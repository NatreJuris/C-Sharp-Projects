using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Id { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:" + FirstName + LastName + Id);
            Console.ReadLine();
        }
    }
}
