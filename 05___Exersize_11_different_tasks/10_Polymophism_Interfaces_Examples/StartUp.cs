using System;
using System.Collections.Generic;
using AbstractionAndInterfaces.Animals;
using AbstractionAndInterfaces.cars;

namespace AbstractionAndInterfaces
{
    public class StartUp
    {
        public static void Main()
        {
           var bunny = new Bunny { Name = "WHAT UP DOG"};
           var firstresult = bunny.SayHello();
           Console.WriteLine(firstresult);

           // this is typical usage of polymorphism
           // we use virtual metods or abstract and we override them 
           var listOFanimals = new List<Animal>();
            listOFanimals.Add(new Cat { Name = "tom" });
           listOFanimals.Add(new Dog { Name = "rex" });
           listOFanimals.Add(new Bunny { Name = "buxter" });
           foreach (var animal in listOFanimals)
           {
               Console.WriteLine(animal.SayHello());
           }

            // INterfaces example 
            var cars = new List<ICar>();
            cars.Add(new Mercedes("CLS"));
            cars.Add(new Bmw("7series"));
            cars.Add(new Mercedes("new CLS"));
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }

            // another example of polymorphism
            IEnumerable<int> numbers = new int[5];
            numbers = new List<int>();
            numbers = new HashSet<int>();


        }
    }
}
