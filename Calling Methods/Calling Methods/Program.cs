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

            AddNumbers Add = new AddNumbers();
            Console.ReadLine();
            SubtractNumbers sub = new SubtractNumbers();
            Console.ReadLine();
            MultiplyNumbers mult = new MultiplyNumbers();
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


