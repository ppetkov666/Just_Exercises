using System;
using System.Collections.Generic;

namespace _04_Fourth_Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // this is just example how we execute the program from CMD 
            //1. we copy the path to the 04_Fourth_Example.dll
            //2. we add to the path - dotnet and the the name of the .dll
            //3. we enter parameteres from name and age and we start it
            var name = args[0];
            var age = int.Parse(args[1]);
            Console.WriteLine($"Hi i am {name} and i am {age} years old");

            //just a simple exam for polymophism and cast !
            IAnimal rabbit = new Rabbit();
            var rabbitAge = ((Rabbit)rabbit).age;
            rabbitAge = 3;
            IAnimal cat = new Cat();
            var listOfAnimals = new List<IAnimal>();
            listOfAnimals.Add(rabbit);
            listOfAnimals.Add(cat);
            foreach (var item in listOfAnimals)
            {
                Console.WriteLine(item.Reproduce());
            }
        }
    }
    interface IAnimal
    {
        string Reproduce();
    }
    class Rabbit : IAnimal
    {
        public int age;
        public string Reproduce()
        {
            return "i am Rabbit and Reproduce very fast";
        }
    }
    class Cat : IAnimal
    {
        public string Reproduce()
        {
            return "i am Cat and Reproduce not so fast";
        }
    }
}
