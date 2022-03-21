using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do
{
    class Program
    {
        static void Main(string[] args)
        {                                                       //while loop
            int count = 1;
            while (count <= 4)
            {
                Console.WriteLine("The value of i is : " + count);
                count = count + 1;
            }
            Console.ReadKey();
                                                                //end while loop
    


                                                                //do while loop
            Console.WriteLine("Pick a number from 1 to 13.");
            int num = Convert.ToInt32(Console.ReadLine());
            bool pick = false;

            do
            {
                switch (num)                    //you litterally cannot pick the correct number
                {
                    case 1:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("nope.......you can't win this game");
                        Console.WriteLine("you really want to try again? Pick a number form 1 to 13.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("still no");
                        Console.ReadLine();
                        break;
                }
                

            }
            
            while (pick == false);
            Console.Read();
                                                        //end do while loop
        }
    }
}