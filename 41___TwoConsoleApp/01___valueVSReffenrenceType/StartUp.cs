
namespace valueVSReffenrenceType
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main(string[] args)
        {
            // reference type example
            Object firstPerson= new Person();
            ((Person)firstPerson).Age = 20;
            Person secondP = (Person)firstPerson;
            secondP.Age = 30;
            Console.WriteLine(((Person)firstPerson).Age);
            Console.WriteLine(secondP.Age);
            // value type example
            int age = 30;
            int secondAge = age;
            Console.WriteLine(age);

            // in c# everything is object !
            object ages = 30;
            Console.WriteLine(ages);
            
        }
    }
}
