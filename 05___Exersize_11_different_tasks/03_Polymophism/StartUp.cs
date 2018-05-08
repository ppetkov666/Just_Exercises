namespace Inheritance_and_PolyMorph
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal cat = new Cat();
            Animal dog = new Dog();
            animals.Add(cat);
            animals.Add(dog);
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine(animal.Print());
                Console.WriteLine(animal.Run());
                animal.Eat();
            }
        }
    }
}
