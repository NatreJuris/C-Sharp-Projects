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
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add.Method(number));
            Console.ReadLine();

            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(add.Method(number1));
            Console.ReadLine();

            string number2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(add.Method(number2));
            Console.ReadLine();
        }
    }
}
