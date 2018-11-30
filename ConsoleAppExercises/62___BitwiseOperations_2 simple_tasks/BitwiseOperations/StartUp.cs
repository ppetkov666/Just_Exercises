using System;

namespace BitwiseOperations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CustomBitFunk(number);
        }

        private static void CustomBitFunk(int number)
        {

            string firstP = Convert.ToString(number, 2).PadLeft(4,'0');
            Console.WriteLine(firstP);
            int mask = 1 <<1;
            string secondP = Convert.ToString(mask, 2).PadLeft(4, '0');
            Console.WriteLine(secondP);
            var result = number & mask;
            string convertedResult = Convert.ToString(result, 2).PadLeft(4, '0');
            result = result >> 1;
            Console.WriteLine(result);

        }
    }
}
