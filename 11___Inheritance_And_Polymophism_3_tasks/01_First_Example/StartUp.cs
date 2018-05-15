namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var uTeacher = new UniversityTeacher(20);
            var teacher = new Teacher(23);
            var person = new Person(33);
            var liststorage = new List<Person>();

            liststorage.Add(uTeacher);
            liststorage.Add(teacher);
            liststorage.Add(person);
            // just a simple exam of polymophism
            foreach (var item in liststorage)
            {
                Console.WriteLine(item.SayHello());
            }
            
        }
    }
}
