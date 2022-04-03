using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Math
    {
        public int Method(int num)
        {
            return num * 2;
        }
        public decimal Method(decimal num)
        {
            return num / 2;
        }
        public string Method( string x)
        {
            int result = 0;
            try
            {
                int num2 = Int32.Parse(x);
                int o = num2 + 3;
                x = Convert.ToString(o);
                return Convert.ToString(x);
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered an invalid numeric value. Feel free to restart and try again.");
                result = 0;
            }
            return Convert.ToString(result);
        }

    }   
}
