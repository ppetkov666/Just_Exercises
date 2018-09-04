using System;

namespace _01___PasswordGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputA = int.Parse(Console.ReadLine());
            var inputB = char.Parse(Console.ReadLine().ToUpper());
            var inputC = char.Parse(Console.ReadLine().ToLower());
            var inputD = int.Parse(Console.ReadLine());
            var inputE = int.Parse(Console.ReadLine());
            var inputF = int.Parse(Console.ReadLine());
            var n = long.Parse(Console.ReadLine());
            long counter = 0;
            bool istrue = true;
            for (int a = 1; a <= inputA; a++)
            {
                for (char b = 'A'; b <= inputB; b++)
                {
                    for (char c = 'a'; c <= inputC; c++)
                    {
                        for (int d = 1; d <= inputD; d++)
                        {
                            for (int e = 1; e <= inputE; e++)
                            {
                                for (int f = 1; f <= inputF; f++)
                                {
                                    counter++;
                                    if (counter == n)
                                    {
                                        istrue = false;
                                        Console.WriteLine($"{a}{b}{c}{d}{e}{f}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (istrue)
            {
                Console.WriteLine("No password on this position");
            }
        }
    }
}
