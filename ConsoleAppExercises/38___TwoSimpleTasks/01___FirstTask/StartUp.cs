using System;

namespace _01___FirstTask
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // this task include optional parameter and 2 examples for 
            // static and non static methods 
            int first = 5;
            int second = 7;
            int third = 100;

            StartUp petko = new StartUp();
            int sumTwoParameters = petko.SumTwoNumbers(first, second);
            Console.WriteLine(sumTwoParameters);

            int sumTreeParameters = SumTwoNumbersV2(first, second, third);
            Console.WriteLine(sumTreeParameters);
        }
        public int SumTwoNumbers(int first, int second, int third = 20)
        {
            var sum = first + second + third;
            return sum;
        }
        public static int SumTwoNumbersV2(int first, int second, int third = 20)
        {
            var sum = first + second + third;
            return sum;
        }
    }
}
