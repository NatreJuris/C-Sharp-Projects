using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTim
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);
            Console.ReadLine();
            Console.WriteLine("Enter a number.");
            double num = Double.Parse(Console.ReadLine());
            
            DateTime dt = localDate.AddHours(num);

            Console.WriteLine(dt);
            Console.ReadLine();

          
        }
    }
}
