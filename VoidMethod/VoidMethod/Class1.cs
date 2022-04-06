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
            Class1.Method(ref num, out int x);

        }
        public static void Method(ref int num, out int x)
        {

            Console.ReadLine();
            x = num / 2;
        }
    }
}
