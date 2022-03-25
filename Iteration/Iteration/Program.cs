using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Sting Array");
            int count = 0;
            while (true)                                        // infinite loop
            {
                Console.WriteLine("Count = {0}.", count);       //writes number of times loop has ran
                count++;                                        

                string[] names = { "Mike", "John", "Frank", "Paul", "Albert", "Justin", "Susan", "Ann", "Heather" };
                Console.WriteLine("Input text");
                string a = Console.ReadLine();                  //user input
                foreach (string name in names)                  //loop that iterates through each string in the array
                {

                    Console.WriteLine(name + a);                //adds the user's text input to the end of each string
                }
                Console.ReadLine();
                for (int i = 0; i < 0; i++)
                {
                    names[i] = Console.ReadLine();               
                }


                if (!(count < 25))                              //determine whether to continue iterating
                {
                    break;
                }
            }
            Console.Clear();
                Console.WriteLine("string Array");

                int count1 = 0;
                while (true)
                {
                    Console.WriteLine("Count = {0}.", count1);  //writes number of times loop has ran
                    count1++;

                    string[] names1 = { "Mike", "John", "Frank", "Paul", "Albert", "Justin", "Susan", "Ann", "Heather" };
                    Console.WriteLine("Input text");
                    string b = Console.ReadLine();              //user input
                    foreach (string name1 in names1)
                    {

                        Console.WriteLine(name1 + b);
                    }
                    Console.ReadLine();
                    for (int q = 0; q <= 0; q++)
                    {
                        names1[q] = Console.ReadLine();
                    }
                    if (!(count1 <= 25))                        //determine whether to continue iterating
                {
                            break;
                        }
                }
            Console.Clear();
            Console.WriteLine("Sting Array User Input Search Find First");
            List<string> names2 = new List<string>();           
            names2.Add("Mike");
            names2.Add("John");
            names2.Add("Frank");
            names2.Add("Paul");
            names2.Add("Albert");
            names2.Add("Justin");
            names2.Add("Susan");
            names2.Add("Ann");
            names2.Add("Heather");
            names2.Add("Racheal");
            names2.Add("Minnie");
            names2.Add("Mickey");
            names2.Add("Don");
            names2.Add("Daisy");
            names2.Add("Brenda");
            Console.WriteLine("Input text to search for");  //user input search
            string c = Console.ReadLine();
            var result = names2.Find(x => x.Contains(c));
            Console.WriteLine(result);                      //returns first match
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Sting Array User Input Search Find All");
            List<string> names3 = new List<string>();
            names3.Add("Mike");
            names3.Add("John");
            names3.Add("Frank");
            names3.Add("Paul");
            names3.Add("Albert");
            names3.Add("Justin");
            names3.Add("Matt");
            names3.Add("Susan");
            names3.Add("Ann");
            names3.Add("Heather");
            names3.Add("Racheal");
            names3.Add("Minnie");
            names3.Add("Mickey");
            names3.Add("Don");
            names3.Add("Daisy");
            names3.Add("Brenda");
            names3.Add("Mike");
            names3.Add("John");
            names3.Add("Frank");
            names3.Add("Paul");
            names3.Add("Albert");
            names3.Add("Justin");
            names3.Add("Matt");
            names3.Add("Susan");
            names3.Add("Ann");
            names3.Add("Heather");
            names3.Add("Racheal");
            names3.Add("Minnie");
            names3.Add("Mickey");
            names3.Add("Don");
            names3.Add("Daisy");
            names3.Add("Brenda");
            Console.WriteLine("Input text to search for");
            string v = Console.ReadLine();                  //user input search
            var d = v;
            List<string> results = new List<string>(names3.FindAll(x => x.Contains(d)));

            foreach (string i in results)                   //returns all matches
            {
                Console.WriteLine(i);
            }
            if ((results.Count) == 0)
            {
                Console.WriteLine("No Match Found");        //exception
            }
            Console.ReadLine();
            
            Console.Clear();                                
            Console.WriteLine("Sting Array Check For Duplicates");
            List<string> names4 = new List<string>();
            names4.Add("Mike");
            names4.Add("John");
            names4.Add("Frank");
            names4.Add("Paul");
            names4.Add("Albert");
            names4.Add("Justin");
            names4.Add("Matt");
            names4.Add("Susan");
            names4.Add("Ann");
            names4.Add("Heather");
            names4.Add("Racheal");
            names4.Add("Minnie");
            names4.Add("Mickey");
            names4.Add("Don");
            names4.Add("Daisy");
            names4.Add("Brenda");
            names4.Add("Mike");
            names4.Add("John");
            names4.Add("Frank");
            names4.Add("Paul");
            names4.Add("Albert");
            names4.Add("Justin");
            names4.Add("Matt");
            names4.Add("Susan");
            names4.Add("Ann");
            names4.Add("Heather");
            names4.Add("Racheal");
            names4.Add("Minnie");
            names4.Add("Mickey");
            names4.Add("Don");
            names4.Add("Daisy");
            names4.Add("Brenda");
            var duplicates = new List<string>();

            foreach (var name in names4)
            {
                if (!names4.Contains(name))
                    names4.Add(name);
                else
                    duplicates.Add(name);
            }

                                                                                  
            foreach (var name in names4)
                Console.WriteLine(name);
            

                                                                                 //  duplicates list
            foreach (var name in duplicates)
                Console.WriteLine(name + "    duplicate");
            Console.ReadLine();

        }
    }
}
