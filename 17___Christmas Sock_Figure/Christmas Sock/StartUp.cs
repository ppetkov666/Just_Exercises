namespace Christmas_Sock
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            DrawFirstPart(n);
            DrawSecondPart(n);
            DrawLastPart(n);
        }
        public static void DrawFirstPart(int n)
        {
            var dashes = new string('-', n * 2);
            var stars = new string('*', n * 2);
            var first = string.Format($"|{dashes}|");
            var second = string.Format($"|{stars}|");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(first);
        }
        public static void DrawSecondPart(int n)
        {
            var lenght = n * 2 - 3;
            var counterDashes = (n * 2 - 2) / 2;
            var dashesSecond = new string('-', counterDashes);
            var specialSymbolsCounter = 2;
            var specialSymbols = new string('~', specialSymbolsCounter);
            var secondFormat = string.Format($"|{dashesSecond}{specialSymbols}{dashesSecond}|");
            for (int i = 0; i < lenght; i++)
            {
                if (i > lenght / 2)
                {

                    counterDashes++;
                    dashesSecond = new string('-', counterDashes);
                    specialSymbolsCounter -= 2;
                    specialSymbols = new string('~', specialSymbolsCounter);
                    secondFormat = string.Format($"|{dashesSecond}{specialSymbols}{dashesSecond}|");
                    Console.WriteLine(secondFormat);

                }
                else
                {
                    dashesSecond = new string('-', counterDashes);
                    specialSymbols = new string('~', specialSymbolsCounter);
                    secondFormat = string.Format($"|{dashesSecond}{specialSymbols}{dashesSecond}|");
                    Console.WriteLine(secondFormat);
                    if (i == lenght / 2)
                    {
                        continue;
                    }
                    else
                    {
                        counterDashes--;
                        specialSymbolsCounter += 2;
                    }
                }
            }
        }
        public static void DrawLastPart(int n)
        {
            var loopLenght = 3 * n + 3 - 2 * n;
            var lastCounterDashes = 0;
            var lastDashes = new string('-', lastCounterDashes);
            for (int i = 0; i < loopLenght; i++)
            {
                if (i == n / 2)
                {
                    var dots = new string('.', (2 * n + 1 - 5) / 2);

                    lastDashes = new string('-', lastCounterDashes);
                    var merry = string.Format($"{lastDashes}\\{dots}MERRY{dots}\\");
                    Console.WriteLine(merry);
                    lastCounterDashes++;
                }
                else if (i == n / 2 + 2)
                {
                    var dots = new string('.', (2 * n + 1 - 5) / 2);

                    lastDashes = new string('-', lastCounterDashes);
                    var merry = string.Format($"{lastDashes}\\{dots}X-MAS{dots}\\");
                    Console.WriteLine(merry);
                    lastCounterDashes++;
                }
                else if (i == loopLenght - 1)
                {
                    var undescore = new string('_', 2 * n + 1);
                    lastDashes = new string('-', lastCounterDashes);
                    var lastRowFormat = string.Format($"{lastDashes}\\{undescore})");
                    Console.WriteLine(lastRowFormat);
                }
                else
                {

                    var dots = new string('.', 2 * n + 1);
                    lastDashes = new string('-', lastCounterDashes);
                    var thirdFormat = string.Format($"{lastDashes}\\{dots}\\");
                    Console.WriteLine(thirdFormat);
                    lastCounterDashes++;
                }
            }
        } 
    }
}
