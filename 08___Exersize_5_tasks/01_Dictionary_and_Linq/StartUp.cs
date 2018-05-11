namespace _01_Dictionary_and_Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person{ Name = "ivan", Age = 20};
            var secondPerson = new Person { Name = "george", Age = 23 };

            var persons = new List<Person>();
            persons.Add(firstPerson);
            persons.Add(secondPerson);

            var dictPersonFirstOption = persons
                .ToDictionary(p => p.Name, q => q.Age);

            var dictPersonSecondOption = persons
                .ToDictionary(p => p.Name);
            //anonimous class
            var newclassPerson = persons
                .Select(p => new { personName = p.Name, personAge = p.Age });
            
            foreach (var item in dictPersonFirstOption)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
                
            }
            dictPersonSecondOption
                .Select(p => p.Value)
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
