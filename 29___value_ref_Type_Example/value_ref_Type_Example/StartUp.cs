namespace example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            Person p = new Person("petko", 33);
            // p i refference type and we just make r = p
            Person r = p;
            // when we print p.Age and Name , nothing unusual 
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            // because r = p and point the same address as p 
            // once we change the name it will change it on both places
            r.Name = "ivan";
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            Console.WriteLine(r.Age);
            Console.WriteLine(r.Name);
            var age = 55;
            // when we assign the value of age to p.Age 
            // we just copy the age because age in value type 
            p.Age = age;
            // and here when we change the value of age = 77 
            // p.Age will remain the same !!!
            age = 77;
            Console.WriteLine(p.Age);

            var personA = new Person("John", 44);
            var personB = new Person("Edi", 55);
            personA.spouse = personB;
            Console.WriteLine(personA.spouse.Name);
            Console.WriteLine(personA.spouse.Age);

        }


    }

}
