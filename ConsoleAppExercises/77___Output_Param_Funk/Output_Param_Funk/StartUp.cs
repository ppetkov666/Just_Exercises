namespace Output_Param_Funk
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            // this is not the right way to be done !!!
            // but this is just for test purposes to be debugged and to see the behavior of out params !!!
            // the other 2 examples in the solution are the done properly !!
            Test example = new Test();
            int firstNumber = 10;
            int secondNumber = 10;
            Console.WriteLine($"firstNumber:{firstNumber}");
            Console.WriteLine($"firstNumber:{secondNumber}");
            Console.WriteLine("Enter first num you want to add");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num you want to add");
            int secondNum = int.Parse(Console.ReadLine());
            example.Add(firstNum,secondNum, out firstNumber, out secondNumber);

            Console.WriteLine($"Changed Value:{firstNumber}");
            Console.WriteLine($"Changed Value:{secondNumber}");
        }
    }
}
