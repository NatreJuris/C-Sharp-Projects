using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    public class Program
    {

       


        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.FirstName = " Sample ";
            emp1.LastName = "Student1";
            emp1.Id = 1;

            emp1.SayName();

            Employee emp2 = new Employee();
            emp2.FirstName = " Sample ";
            emp2.LastName = "Student2";
            emp2.Id = 2;

            emp2.SayName();
           

            Console.WriteLine("Do these two employees have the same employee Id?");
            Console.ReadLine();

            Console.WriteLine(emp1.Id == emp2.Id);
            Console.ReadLine();
            
        }
            


       

        }
     

    

        //public static Employee operator == (Employee employee)
        //{
        //    employee.Id.Equals(employee.Id);
        //    return employee;

        //}
        //public static Employee operator != (Employee employee)
        //{
        //    employee.Id.Equals(employee.Id);
        //    return employee;

        //}

    }

