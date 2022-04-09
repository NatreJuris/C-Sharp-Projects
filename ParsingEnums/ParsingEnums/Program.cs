using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week.");
            string day = (Console.ReadLine());

            try
            {
                WeekDays days = (WeekDays)Enum.Parse(typeof(WeekDays), day);

                Console.WriteLine("Thanks");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");

                Console.ReadLine();

            }


        }
    }
}
