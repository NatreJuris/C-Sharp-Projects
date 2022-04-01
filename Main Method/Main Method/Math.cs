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
        public double Method(double num)
        {
            return num / 2;
        }
        public string Method( string x)
        {
            int num2 = Int32.Parse(x);
            int o = num2 + 3;
            x = Convert.ToString(o);
            return Convert.ToString(x);
        }

    }   
}
