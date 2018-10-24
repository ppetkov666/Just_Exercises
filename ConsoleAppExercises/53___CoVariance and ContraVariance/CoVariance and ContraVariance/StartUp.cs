
namespace CoVariance_and_ContraVariance
{
    using System;
    using System.Collections.Generic;

    public class Automobile { };
    public class Car : Automobile { };
    public class Truck : Automobile { };
    public class HeavyTruck : Truck { };
    class StartUp
    {
        static void Main(string[] args)
        {
            // we can pass HeavyTruck because it is Truck but We CAN'T pass  Car or Automobile
            Describe(new Truck());
            Describe(new HeavyTruck());
            //Describe(new Automobile());
            //Describe(new Car());
            // we can also set the following :
            List<Truck> trucks = new List<Truck>();
            trucks.Add(new Truck());
            trucks.Add(new HeavyTruck());
            IEnumerable<Automobile> autos = new List<Truck>();
            IEnumerable<Automobile> autosV2 = trucks;
            foreach (var auto in autosV2)
            {
                Console.WriteLine(auto.GetType().Name);
            }
            
            // function which accept Automobile as param , accept Truck also because Truck is Automobile
            Action<Truck> contraVariant = DescribeAutomobile;
            contraVariant(new Truck());
            contraVariant(new HeavyTruck());
            // this is not acceptable because car is not a truck  
            //contraVariant(new Car());
            // another way to be done with Lambda expression
            Action<Truck> contraVariantV2 = new Action<Automobile>((Automobile automobile) => 
                                                                  { Console.WriteLine($"The Automobile is {automobile.GetType().Name}"); });
            contraVariantV2(new Truck());
            contraVariantV2(new HeavyTruck());
            // same rule here as upper example
            //contraVariantV2(new Car());

            // if we change the type from Automobile to Car it wont work because Truck is not a car
            //Action<Truck> contraVariantV3 = new Action<Car>((Car value) =>
                                                           //{ Console.WriteLine($"The Automobile is {value.GetType().Name}"); });

            //in this case we will throw an exception because Automobile is not a Truck , but we 'tell'to the Compiler when we cast it that
            // we know what we are doing and it will compile but in Run time it won't work
            Action<Truck> action = new Action<Truck>((Truck value) => { Console.WriteLine($"The Automobile is {value.GetType().Name}"); });
            Action<Automobile> contraVariantV4 = (Action<Automobile>)(action);
        }
        public static void Describe(Truck value)
        {
            Console.WriteLine($"The value is {value.GetType().Name}");
        }
        public static void DescribeAutomobile(Automobile value)
        {
            Console.WriteLine($"The Automobile is {value.GetType().Name}");
        }
    }
}
