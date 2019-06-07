using System;
using static System.Console;
namespace Second_example
{
    class Program
    {
        static void Main(string[] args)
        {
            
                WriteLine("Please enter radious for circle");
                double radious = Convert.ToDouble(ReadLine());
                double circumference = CalculateCircle(radious, out double area);
                WriteLine($"Circle's circumference is {circumference}");
                WriteLine($"Circle's Area is {area}");
                ReadKey();

        }
        static double CalculateCircle(double radious, out double area)
        {
            area = Math.PI * Math.Pow(radious, 2);
            double circumference = 2 * Math.PI * radious;
            return circumference;
        }
    }
}
