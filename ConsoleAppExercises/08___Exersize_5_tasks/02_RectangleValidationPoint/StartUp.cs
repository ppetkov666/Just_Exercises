namespace _02_RectangleValidationPoint
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangle = new Rectangle();
            
            rectangle.CreateRectangle(input[0], input[1], input[2], input[3]);
            var point = new Point(Console.ReadLine);

            var pointPosition = rectangle.CheckThePoint(point);
            if (pointPosition)
            {
                Console.WriteLine($"The point is inside the Rectangle");
            }
            else
            {
                Console.WriteLine("The point is outside the rectangle");
            }
        }
        
    }
}
