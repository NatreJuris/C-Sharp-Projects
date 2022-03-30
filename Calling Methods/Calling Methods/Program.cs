using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class SimpleMath
    {

       

        static void Main(string[] args)
        {


            AddNumbers add = new AddNumbers();
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add.AddNumber(number));
            Console.ReadLine();
            
            AddNumbers sub = new AddNumbers();
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sub.SubtrackNumber(number1));
            Console.ReadLine();
            
            AddNumbers mult = new AddNumbers();
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mult.MultiplyNumber(number2));
            Console.ReadLine();


        }


        



        //public int AddNumbers(int addnumber)
        //{
        //    Console.WriteLine("This is your number plus 5.");
        //    return addnumber;
        //    Console.WriteLine(addnumber);
        //    Console.ReadLine();

        //}
        //public int subtractnumbers(int number)
        //{
        //    return number * number;
        //}
        //public int multiplynumbers(int number)
        //{
        //    return number * number;
        //}
        //public int addnumber { get; }

    }
}


