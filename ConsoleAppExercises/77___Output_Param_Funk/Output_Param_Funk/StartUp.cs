namespace Output_Param_Funk
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            Test example = new Test();
            int firstNumber = 10;
            int secondNumber = 20;
            Console.WriteLine($"firstNumber:{firstNumber}");
            Console.WriteLine($"firstNumber:{secondNumber}");

            example.GetNums(out firstNumber, out secondNumber);

            Console.WriteLine($"Changed Value:{firstNumber}");
            Console.WriteLine($"Changed Value:{secondNumber}");
        }
    }
}
