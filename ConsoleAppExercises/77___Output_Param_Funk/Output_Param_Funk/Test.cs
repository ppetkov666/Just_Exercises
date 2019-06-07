

namespace Output_Param_Funk
{
    using System;
    public class Test
    {
        public void Add(int firstNum,int secondNum,out int firstNumber, out int secondNumber)
        {
            System.Console.WriteLine("Enter the value to change: ");
            int firstN = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the value to change: ");
            int secondN = int.Parse(Console.ReadLine());
            firstNumber = firstN;
            secondNumber = secondN;


        }
    }
}
