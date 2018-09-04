namespace _06_MyCustomExtensionMethods
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            var first = Check(2, n => n % 2 == 0);
            var second = Check(150, n => n > 100);
            var third = Check(33, n => n % 2 != 0);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            CheckAction(22, n => Console.WriteLine(n));

            var dashes = "--name--";
            var modifiedDashes = dashes.MyPersonalTrim();
            Console.WriteLine(modifiedDashes);

            var hashsetInt = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            hashsetInt.ForEach(n => Console.WriteLine(n));
            var hashstring = new HashSet<string>() { "pet", "shest", "sedem" };
            hashstring.ForEach(st => Console.WriteLine(st + "!"));
            var listOfStack = new Stack<string>();
            listOfStack.Push("five");
            listOfStack.Push("six");
            listOfStack.Push("seven");
            listOfStack.ForEach(n => Console.WriteLine(n + 100));
        }
        public static void CheckAction(int a, Action<int> action)
        {
            action(a + 10000);
        }
        public static bool Check(int a, Func<int, bool> function)
        {
            return function(a);
        }
    }
}
