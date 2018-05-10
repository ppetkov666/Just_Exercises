namespace _04_whatever
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var square = Math.Sqrt(n);
            CheckPerfectSquare(n, square);
        }

        private static void CheckPerfectSquare(int n, double square)
        {
            if (square % 1 == 0)
            {
                Console.WriteLine($"{n} has a integral square root of {square}");
            }
            else
            {
                Console.WriteLine($"{n} does not have \"integral\" square root");
            }
        }
    }
}
