using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class AddNumbers
    {



        public AddNumbers()
        {
            Console.WriteLine("enter a number to perform math operations on.");
            int X = int.Parse(Console.ReadLine());
            int num = X + 5;
            Console.WriteLine("This is your number plus 5.");
            Console.WriteLine(num);
            Console.ReadLine();



        }

    }
}
