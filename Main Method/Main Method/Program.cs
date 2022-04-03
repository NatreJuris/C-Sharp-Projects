using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Math add = new Math();
            Console.WriteLine("Enter a number to multiply by 2.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add.Method(number));
            Console.ReadLine();

            Console.WriteLine("Enter a decimal to divide by 2.");
            decimal number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add.Method(number1));
            Console.ReadLine();

            Console.WriteLine("Enter a numeric string to add 3 to.");
            string number2 = (Console.ReadLine());
            Console.WriteLine(add.Method(number2));
            Console.ReadLine();
        }
    }
}
