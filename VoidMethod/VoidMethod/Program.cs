using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VoidMethod.Class1;

namespace VoidMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be divided by 2.");
            int num = Convert.ToInt32(Console.ReadLine());
            Method(num);

        }
    }
}
