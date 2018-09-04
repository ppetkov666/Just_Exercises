namespace _02_Reading_Input_Params
{
    using System;
    using System.Collections.Generic;

    class StartUP
    {
        static void Main(string[] args)
        {
            var listOfPersons = new List<PersonBasicInfo>();
            var input = Console.ReadLine().Split();

            var name = input[0];
            var age = input[1];
            var car = input[2];

            var tires = new List<Tire>();
            var pressure = 3;
            var size = 4;
            for (int tireCount = 0; tireCount < 4; tireCount++)
            {
                var tire = new Tire(int.Parse(input[pressure]), int.Parse(input[size]));
                tires.Add(tire);
                pressure+=2;
                size+=2;
            }
            var personFullInfo = new PersonBasicInfo(name, age, car, tires);
            listOfPersons.Add(personFullInfo);
            foreach (var p in listOfPersons)
            {
                Console.WriteLine($"I am {p.name},{p.age} old,i drive {p.car}");
                Console.WriteLine("My tires has the following specifications:");
                int counter = 1;
                foreach (var tyre in p.carTires)
                {  
                    if (counter == 1) Console.Write("First Tire: ");
                    else if (counter == 2) Console.Write("Second Tire: ");
                    else if (counter == 3) Console.Write("Third Tire: ");
                    else if (counter == 4) Console.Write("Fourth Tire: ");

                    Console.WriteLine($" {tyre.Pressure},{tyre.Size}");
                    counter++;
                }
            }
        }
    }
}
