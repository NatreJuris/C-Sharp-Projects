using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Overload
{
    static class Program
    {
        public static int num { get; set; }
        

        public static void Main(string[] args)
        {
            Purple purple = new Purple();
            Console.WriteLine("Enter a number to be divided in two.");
            purple.First(num);

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number/2);
            Console.ReadLine();

        }
    }
}
