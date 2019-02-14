namespace StaticClasses
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //each instance is a copy so if i have 1000 instances i will have 1000 copies od it's instance variables and methods
            // on my class
            Circle firstCircle = new Circle(5);
            Single areaFirst = firstCircle.CalculateArea();
            Circle secondCircle = new Circle(6);
            Single areaSecond = secondCircle.CalculateArea();

            Console.WriteLine($"{areaFirst}");
            Console.WriteLine($"{areaSecond}");

            // my variable PI is static and  i will use only that variable no matter how many objects i create
            StaticCircle first = new StaticCircle(5);
            Console.WriteLine(first.CalculateArea());
            StaticCircle second = new StaticCircle(6);
            Console.WriteLine(second.CalculateArea());

            // this is one typical usage of static classes
            double celcius = 37;
            double fahrenheit = 99;
            Console.WriteLine($"The value of {celcius} celcius in fahrenheit is {Converter.ToFahrenheit(celcius):f0}");
            Console.WriteLine($"The values of {fahrenheit} fahrenheit is {Converter.ToCelcius(fahrenheit):f0}");

        }
    }
}
