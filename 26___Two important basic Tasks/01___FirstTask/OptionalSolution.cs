namespace _01___FirstTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OptionalSolution
    {
        public const char POSITIVE_BIT = '1';
        public static void Solution(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            int counter = 0;
            // here i am using the Class Convert which is included in Visual Studio
            string binaryResult = Convert.ToString(result, 2);
            foreach (char item in binaryResult)
            {
                if (item == POSITIVE_BIT)
                {
                    counter++;
                }
            }
            Console.WriteLine($"The binary representation of {result} is {binaryResult}");
            Console.WriteLine($"{binaryResult} contains {counter} bits set to {POSITIVE_BIT}");
        }
    }
}
