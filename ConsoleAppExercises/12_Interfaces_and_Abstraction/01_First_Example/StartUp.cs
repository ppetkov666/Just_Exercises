namespace _01_First_Example
{
    using System;
    using Cars;
    using System.Collections.Generic;
    using Animals;
    using MyBunny = Animals.Bunny;
    using MyDog = Animals.Dog;
    class StartUp
    {
        static void Main(string[] args)
        {
            // the difference bettween abstract or virtual and New !
            Bmw bmw = new Bmw();
            Console.WriteLine(bmw.Start());
            Car bmwAsCar = new Bmw();
            Console.WriteLine(bmwAsCar.Start());

            var ListOfAnimals = new List<Animal>();
            ListOfAnimals.Add(new Cat());
            ListOfAnimals.Add(new Dog());
            ListOfAnimals.Add(new MyBunny());
            foreach (var item in ListOfAnimals)
            {
                Console.WriteLine(item.SayHello());
                Console.WriteLine(item.PrintMyName());
            }

            // just an example about the namespaces and how we can access it 
            MyBunny bunny = new Animals.Bunny();
            Animals.Cat cat = new Cat();
            MyDog dog = new MyDog();
            Dog anotherDog = new Dog();
            // this is Class bunny but not from the from forder Animals
            Bunny anotherBunny = new Bunny();
        }
    }
}
