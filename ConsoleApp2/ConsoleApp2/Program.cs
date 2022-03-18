using System;


    class Program
    {
        static void Main()
        {
        int num1;
        int num2;
        int num3;
        int num4;
        int num5;
        int num6;
        Console.WriteLine("Anonymous income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week");
        num4 = Convert.ToInt32(Console.ReadLine());
        num5 = (num1 * num2)*52;
        num6 = (num3 * num4)*52;
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(num5);
        Console.ReadLine();
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(num6);
        Console.ReadLine();
        bool more = num5 > num6;
        Console.WriteLine("Does Person 1 make more than Person 2");
        Console.WriteLine(more);
        Console.ReadLine();




    }
}

