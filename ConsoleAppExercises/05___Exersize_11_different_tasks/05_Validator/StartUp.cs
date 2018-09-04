namespace _05_Validator
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car(5, "bmw");
            Console.WriteLine(car.Start());
        }
    }
}
