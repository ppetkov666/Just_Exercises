using System;
using System.Collections.Generic;

namespace AnonimousMethods
{
    class Program
    {
        public delegate bool CustomDelegate(Employee emp);
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "Ivan"},
                new Employee{ Id = 2, Name = "Georgi"},
                new Employee{ Id = 3, Name = "John"},
            };

            Employee first = employees.Find(a => a.Id == 2);
            Console.WriteLine(first.Id + " " + first.Name + " done just with lambda");

            Employee second = employees.Find((Employee a) => a.Id == 2);
            Console.WriteLine(second.Id + " " + second.Name + " done with lambda explicitly ");

            Employee third = employees.Find(a => SearchedEmployee(a));
            Console.WriteLine(third.Id + " " + third.Name + " done with lambda expression using method");

            Predicate<Employee> fourthPredicate = new Predicate<Employee>(SearchedEmployee);
            Employee fourth = employees.Find(a => fourthPredicate(a));
            Console.WriteLine(fourth.Id + " " + fourth.Name + " done with predicate delegate and lambda");

            Predicate<Employee> fifrthPredicate = new Predicate<Employee>(SearchedEmployee);
            Employee fifth = employees.Find(fifrthPredicate);
            Console.WriteLine(fifth.Id + " " + fifth.Name + " done by predicate");

            CustomDelegate sixCustom = new CustomDelegate(SearchedEmployee);
            Employee six = employees.Find(x=>sixCustom(x));
            Console.WriteLine(six.Id + " " + six.Name + " done by CustomDelegate");

            Employee anonimous = employees.Find(delegate (Employee a)
           {
               return a.Id == 2;
           });
            Console.WriteLine(anonimous.Id + " " + anonimous.Name + " done by annonimous function");

            


        }
        public static bool SearchedEmployee(Employee emp)
        {
            return emp.Id == 2;
        }
    }
}
