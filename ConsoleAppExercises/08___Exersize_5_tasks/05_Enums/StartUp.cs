namespace _05_Enums
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var pricePerNIght = decimal.Parse(input[0]);
            var nights = int.Parse(input[1]);
            var season = Enum.Parse<SeasonMultiplier>(input[2]);
            var discount = Discount.None;
            decimal tempSum = pricePerNIght * nights * (int)season;
            if (input.Length > 3)
            {
                discount = Enum.Parse<Discount>(input[3]);
                var sum = tempSum * (1 - (decimal)discount / 100);
                Console.WriteLine($"{sum:f2}");
               
            }
            else
            {
                Console.WriteLine(tempSum);
            } 
        }
    }
}
