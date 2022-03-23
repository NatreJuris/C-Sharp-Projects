using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sting Array");
            try
            {
                string[] names = { "Jane", "Thomas", "Lucy", "David" };             //creates string array
                Console.WriteLine(names[0]);
                Console.WriteLine(names[1]);                                        //writes array to console
                Console.WriteLine(names[2]);
                Console.WriteLine(names[3]);
                Console.ReadLine();
                Console.WriteLine("Select an index");
                int index = int.Parse(Console.ReadLine());                          //user selects index
                Console.WriteLine(names[index].ToString());
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException e)                                      //displays error if outside of index
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }                                                                       //end string array
            Console.WriteLine("Int Array");

            try
            {
                int[] num = { 1, 243, 546, 3987 };                                  //creates int array
                Console.WriteLine(num[0]);
                Console.WriteLine(num[1]);                                        //writes array to console
                Console.WriteLine(num[2]);
                Console.WriteLine(num[3]);
                Console.ReadLine();
                Console.WriteLine("Select an index");
                int index1 = int.Parse(Console.ReadLine());                          //user selects index
                Console.WriteLine(num[index1].ToString());
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException w)                                      //displays error if outside of index
            {
                Console.WriteLine(w);
                Console.ReadLine();
            }                                                                       //end int array

            Console.WriteLine("Now a List of Stings");                              
            try
            { 
                List<string> icons = new List<string>                               //String list
                {
                   "!","!","N","N",",",",","k","k",
                   "b","b","v","v","w","w","z","z"
                };
                Console.WriteLine("Select an index");
                int index3 = int.Parse(Console.ReadLine());                          //user selects index
                Console.WriteLine(icons[index3].ToString());
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException a)                                      //displays error if outside of index
            {
                Console.WriteLine(a);
                Console.ReadLine();
            }
                                                                                    //end string list

}
    }
}
