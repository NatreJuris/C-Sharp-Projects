using System;




    class Program
    {
        static void Main()
        {
        int num1;
        int num2;
        bool dui;

        Console.WriteLine("What is your age?");             //checks age
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI?");      //checks dui
        dui = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");    //checks tickets
        num2 = Convert.ToInt32(Console.ReadLine());
        bool ins = (num1 > 15 != dui  && num2 < 3);
        Console.WriteLine("Qualified?");                    //output true/false if qualified
        Console.WriteLine(ins);
        Console.ReadLine();

    }
    }

