namespace _04_OtherExtensionMethods
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            string[] arraystorage = new string[input];
            for (int i = 0; i < input; i++)
            {
                var secondInput = int.Parse(Console.ReadLine());
                string readytoadd = secondInput.PrintDefaultMessageAfterNumber();
                arraystorage[i] = readytoadd;
                
            }
            for (int i = 0; i < arraystorage.Length; i++)
            {
                Console.WriteLine(arraystorage[i]);
            }
            // second option but without extension method
            int number = 10;
            var printOutput= Extension.PrintDefaultMessage(number);
            Console.WriteLine(printOutput);
        }
    }
}
