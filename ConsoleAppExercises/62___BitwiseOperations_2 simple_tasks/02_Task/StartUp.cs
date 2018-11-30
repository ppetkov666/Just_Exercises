using System;

namespace _02_Task
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            CustomBitFunk(number, position);
        }
        private static void CustomBitFunk(int number,int position)
        {
           

            string firstP = Convert.ToString(number, 2).PadLeft(4, '0');
            Console.WriteLine(firstP);
            int mask = 1 << position;
            string secondP = Convert.ToString(mask, 2).PadLeft(4, '0');
            Console.WriteLine(secondP);
            var result = number & mask;
            string convertedResult = Convert.ToString(result, 2).PadLeft(4, '0');
            Console.WriteLine(convertedResult);
            result = result >> position;
            Console.WriteLine(result);

        }
    }
}
