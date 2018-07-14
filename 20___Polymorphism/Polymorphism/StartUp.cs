using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var listofAnimals = new List<Animal>();
            Animal cat = new Cat("peshoni",18);

            Animal dog = new Dog("bukster", 30);
            listofAnimals.Add(cat);
            listofAnimals.Add(dog);
            foreach (var animal in listofAnimals)
            {
                Console.WriteLine(animal.Run);
                Console.WriteLine(animal.Eyes);
            }




        }
    }
}
