

namespace Output_Param_Funk
{
    using System;
    public class Test
    {
        public void GetNums(out int firstNumber, out int secondNumber)
        {
            System.Console.WriteLine("Enter your first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());

        }
    }
}
