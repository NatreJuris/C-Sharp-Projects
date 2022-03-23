using System;


    class Program
    {
        static void Main()
        {
        

        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Package Weight");                 //asks for package weight
        int weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)                                    //if over 50 will exit program
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();                     
        }
        else                                               //asks for dimensions
        {
            Console.WriteLine("Package Width");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package Height");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package Length");
            int Length = Convert.ToInt32(Console.ReadLine());

            int package = (Width * Height * Length) * weight / 100;  //equation for cost
            if (Width + Height + Length > 50)           //checks dimensions 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();                                 // exit if too big
            }

            else
            {
                Console.WriteLine("Your estimated total for shipping this package is:");
                String cost = package.ToString("c");               //converts to dollar amount
                Console.WriteLine(cost);                           //displays cost for package 
                Console.ReadLine();
            }

        }

        


        }
    }
