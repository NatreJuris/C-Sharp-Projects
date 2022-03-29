using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
   public class SubtractNumbers
        {


        public SubtractNumbers()
        {
            Console.WriteLine("enter a number to perform math operations on.");
            int X = int.Parse(Console.ReadLine());
            int sub = X - 5;
            Console.WriteLine("This is your number minus 5.");
            Console.WriteLine(sub);
            Console.ReadLine();
        }
        } 
}
