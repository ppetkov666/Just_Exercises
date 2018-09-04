namespace _02___SecondTask
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            int maxnumber = int.MinValue;
            int minnumber = int.MaxValue;
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int parsedInput = int.Parse(input);
                if (parsedInput > maxnumber)
                {
                    maxnumber = parsedInput;
                }
                if (parsedInput < minnumber)
                {
                    minnumber = parsedInput;
                }
            }
            Console.WriteLine($"Max number: {maxnumber}");
            Console.WriteLine($"Min number: {minnumber}");
        }
    }
}
