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
}
