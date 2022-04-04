using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Overload
{
    class Purple
    {
  
        public static int num { get; set; }



        public void First(int num, out int x)
        {
            Console.WriteLine(num / 2);
            x = Convert.ToInt32(Console.ReadLine());

           
        }
        public void First(int num)
        {
            Console.WriteLine(num / 2);
        }



    }
}
