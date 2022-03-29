using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class MultiplyNumbers
    {
        public MultiplyNumbers()
        {
            Console.WriteLine("enter a number to perform math operations on.");
            int X = int.Parse(Console.ReadLine());
            int mult = X * 5;
            Console.WriteLine("This is your number times 5.");
            Console.WriteLine(mult);
            Console.ReadLine();
        }
    }
}
