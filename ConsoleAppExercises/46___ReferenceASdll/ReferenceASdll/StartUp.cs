namespace ReferenceASdll
{
    using System;
    using MathOperations;
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            MathOperations petko = new MathOperations(5, 6);
            petko.PrintTheSum();
            petko.PrintTheAbsDifference();
            petko.PrintMultiplyResult();
            petko.PrintDivisionResult();
        }
    }
}
