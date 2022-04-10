using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        static void Main(string[] args)
        {

            
            List<Employee> employee = new List<Employee>() {
                new Employee(){ Id = 1, FirstName="Bill", LastName= "Smith"},
                new Employee(){ Id = 2, FirstName="Steve", LastName= "Cantenberry"},
                new Employee(){ Id = 3, FirstName="Ram", LastName= "Oleson"},
                new Employee(){ Id = 4, FirstName="Abdul", LastName= "Appleseed"},
                new Employee(){ Id = 5, FirstName="Bob", LastName= "Deckum"},
                new Employee(){ Id = 6, FirstName="Ralph", LastName= "Potter"},
                new Employee(){ Id = 7, FirstName="Debby", LastName= "Door"},
                new Employee(){ Id = 8, FirstName="Amanda", LastName= "Buefford"},
                new Employee(){ Id = 9, FirstName="Kurly", LastName= "Rock"},
                new Employee(){ Id = 10, FirstName="Joe", LastName= "Turtle"},
                new Employee(){ Id = 11, FirstName="Carl", LastName= "Nameo"},
                new Employee(){ Id = 12, FirstName="Stacy", LastName= "Tragic"},
                new Employee(){ Id = 13, FirstName="Ash", LastName= "Flew"},
                new Employee(){ Id = 14, FirstName="Joe", LastName= "Josephilum"},
                new Employee(){ Id = 15, FirstName="Mark", LastName= "Rugget"},
                new Employee(){ Id = 16, FirstName="Nancy", LastName= "Lajimualish"}
            };

            Employee emp1 = new Employee();

            //Console.WriteLine("Oldies");
            //employee.FindAll(emp => employee.Id < 1960)
            //     .ForEach(print);
            //Console.WriteLine();

            //foreach (FindAll(emp <employee> "Joe") in employee) ;
            //{
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //foreach (var emp in employee)
            //{
            //    Console.WriteLine("Id={0}, FirstName={1}, LastName={2}", <employee>, employee.FirstName, employee.LastName);
            //}
            foreach (var item in employee)
                if (item.FirstName == "Joe")
                    Console.WriteLine("Id: {0} FirstName: {1} LastName: {2}", item.Id, item.FirstName, item.LastName);
            Console.ReadLine();


            Console.WriteLine(employee.FindAll(emp => (emp1.Id > 5)));
            Console.ReadLine();


            Console.WriteLine(employee.FindAll(emp => emp1.FirstName == "Joe"));
            Console.ReadLine();

            //    foreach (var item in employee)
            //    Console.WriteLine("Id: {0} FirstName: {1} LastName: {2}", item.Id, item.FirstName, item.LastName);
            //Console.ReadLine();


            //for (int i = 0; i < employee.Count; i++)
            //    Console.WriteLine("Id: {0} FirstName: {1} LastName: {2}", employee[i].Id, employee[i].FirstName, employee[i].LastName);
            //Console.ReadLine();

            foreach (var item in employee)
                if (item.FirstName == "Joe") employee.ForEach(em => Console.WriteLine("Id: {0} FirstName: {1} LastName: {2}", item.Id, item.FirstName, item.LastName));
            Console.ReadLine();

        }


    }
}
