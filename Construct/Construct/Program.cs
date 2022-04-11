using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construct
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
            const string yep = "Yep, ";

            var nope = "that's right.";

            var ok = nope;

            Console.WriteLine(yep);
            Console.ReadLine();
            Console.WriteLine(nope);
            Console.ReadLine();
            Console.WriteLine(yep + ok);
            Console.ReadLine();

            
        }
    }
    class Student
    {
        string student = "";
        string d = "";
        string fN = "";
        string lN = "";

        public Student(string id): this(id, "", "")
        {

        }

        public Student(string id, string fName): this(id, fName, "")
        {

        }

        public Student(string id, string fName, string lName)
        {
            student = "student";

            d = id;
            fN = fName;
            lN = lName;
        }
    }
}
    