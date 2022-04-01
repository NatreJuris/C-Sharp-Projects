using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            TakesTwo add = new TakesTwo();
            Console.WriteLine("Input two numbers, one at a time. The second number is optional");
            int number = Convert.ToInt32(Console.ReadLine());
            var number1 = int.TryParse(Console.ReadLine(), out int x);

            int result = 0;
            if (number1)
            {
                result = add.Two(number, x);
            }
            else
            {
                result = add.Two(number);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
