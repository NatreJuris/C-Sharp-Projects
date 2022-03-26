using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();                                     //creates list
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);
            numberList.Add(11);
            numberList.Add(89);
            numberList.Add(23);
            numberList.Add(65);
            numberList.Add(83);
            numberList.Add(27);
            numberList.Add(44);

            try
            {

                foreach (int num in numberList)                                         //displays list
                {

                    Console.WriteLine(num);
                }
                Console.ReadLine();


                Console.WriteLine("Input number to divide each number in the list by");  //user input 
                var userInput = int.Parse(Console.ReadLine());


                foreach (int d in numberList)                                           //divides list numbers by user input
                {
                    var result = d / userInput;
                    Console.WriteLine(result);
                }
                
                Console.ReadLine();

            }

            catch (DivideByZeroException)                                               //exceptions to catch
            {
                Console.WriteLine("Division of {0} by zero.", numberList);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }
            Console.WriteLine("Program has emerged from error and will continue execution.");       //continues execution of program
            Console.ReadLine();
        }   
    }
}
