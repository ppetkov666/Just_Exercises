namespace InterfaceExampleTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> carLsit = new List<Car>();
            Car normalCar = new Car("Diesel", "regular Diesel");
            Car petrolCar = new PetrolCar("Petrol", "old Petrol");
            Car electricCar = new ElectricCar("Electric", "New Electric");
            carLsit.Add(normalCar);
            carLsit.Add(petrolCar);
            carLsit.Add(electricCar);
            foreach (var car in carLsit)
            {
                car.Start();
            }

        }
    }
}
