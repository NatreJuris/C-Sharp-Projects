using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public static class Class1
    {
        public static void Method(int num)
        {
            Console.WriteLine(num / 2);
            Console.ReadLine();

        }
        public static void Method(string h, out int x)
        {
            x = 5;
        }
    }
}
