namespace _01___LibraryExample
{
    using System;
    using MathOperations;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            MathOperations results = new MathOperations(firstnumber,secondNumber);
            results.PrintTheSum();
            results.PrintTheAbsDifference();
            results.PrintMultiplyResult();
            results.PrintDivisionResult();
        }
    }
}
