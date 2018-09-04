
namespace _03_Third_Example
{
    using MyExtension;
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.MyOwnForeach(n => Console.WriteLine(n));
            var listanother = new HashSet<string>();
            listanother.Add("petko");
            listanother.Add("ivan");
            listanother.Add("john");
            listanother.MyUniversalForeach(n => Console.WriteLine(n));

            var number = 5;

            if (number.IntChecker(n=>n % 2 == 0))
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            var name = "petko";
            var upperCasename = name.StringToUpper(n => n.ToUpper());
            Console.WriteLine(upperCasename);
        }
    }
}
