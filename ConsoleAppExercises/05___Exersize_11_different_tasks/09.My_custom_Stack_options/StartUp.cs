namespace next_test
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var test = new Class1();
            test.Push("john");
            test.Push("sara");
            test.Push("ivan");

            Console.WriteLine(test.IsEmpthy());
            Console.WriteLine(test.Peek());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());

        }

    }
}
