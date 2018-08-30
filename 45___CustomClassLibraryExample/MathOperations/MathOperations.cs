using System;

namespace MathOperations
{
    public class MathOperations
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public MathOperations(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public void PrintOnTheConsole(double result)
        {
            Console.WriteLine($"The Result is: {result:f2}");
        }
        public void PrintTheSum()
        {
            double result = FirstNumber + SecondNumber; 
            PrintOnTheConsole(result);

        }
        public void PrintTheAbsDifference()
        {
            double result = Math.Abs(FirstNumber - SecondNumber);
            PrintOnTheConsole(result);

        }
        public void PrintMultiplyResult()
        {
            double result = FirstNumber * SecondNumber;
            PrintOnTheConsole(result);
        }
        public void PrintDivisionResult()
        {
            double result = (double)FirstNumber / SecondNumber;
            PrintOnTheConsole(result);
        }
    }
}
