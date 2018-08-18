using System;

namespace _02___Char_sTransformation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCodes = int.Parse(Console.ReadLine());
            int count = 0;
            var beginingM = 32;
            var beginingN = 57;
            for (int i = 1; i <= a; i++)
            {
                for (int y = 1; y <= b; y++)
                {
                    beginingM++;
                    beginingN++;

                    if (beginingM > 47)
                    {
                        beginingM = 33;
                    }
                    if (beginingN > 64)
                    {
                        beginingN = 58;
                    }
                    count++;
                    Console.Write($"" +
                        $"{(char)beginingM}" +
                        $"{(char)beginingN}" +
                        $"{i}" +
                        $"{y}" +
                        $"{(char)beginingN}" +
                        $"{(char)beginingM}|");
                    if (count >= maxCodes)
                    {
                        return;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
