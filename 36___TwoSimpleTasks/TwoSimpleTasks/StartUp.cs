namespace _01___FirstTask
{
    using System;

    public class StartUp
    {
        public const string NAMEPRIVATE = "Petko";
         
        static void Main(string[] args)
        {
            var stringMessage = "hello {0},how are you ?";
            PrintMessage(stringMessage, NAMEPRIVATE);

        }
        public static void PrintMessage(string first, string second)
        {
            Console.WriteLine(first, second);
        }

    }
    
}
