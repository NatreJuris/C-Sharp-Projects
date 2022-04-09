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
        public static bool operator == (Employee emp1, Employee emp2)
        {
                return true;
                
        }

        public static bool operator != (Employee emp1, Employee emp2)
        {
           
                return true;
            
        }
    }
}
