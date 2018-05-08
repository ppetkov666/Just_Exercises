namespace _01_Funk_And_Actions_execises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var text = "11";
            var parsedText = int.Parse(text);
            string[] modyfied = new string[] { "1", "2", "3", "4" };
            var newmod = modyfied
                .Select(a =>
                {
                    return int.Parse(a);
                })
                .ToList();

            Action<int, int, int> action = Print;
            Action<int> anotherAction = SecondPrint;
            anotherAction += n => Console.WriteLine(n + 10);
            action(1, 2, 3);
            DoSomethingElse(anotherAction);
            Func<string, int> parseINT = int.Parse;

            Func<int> parseInt = () => 1;

            var petkoList = ReturnDyn();
            foreach (var item in petkoList)
            {
                Console.WriteLine(item);
            }
            String s = null;
            Console.WriteLine(s);

        }
        public static List<dynamic> ReturnDyn()
        {
            var newvar = new List<dynamic>()
            {
                1,"petko",new List<string>(),2
            };
            return newvar;
        }
        public static int Parsing(string name)
        {
            return int.Parse(name);
        }
        private static void SecondPrint(int obj)
        {
            Console.WriteLine(obj);
        }

        public static void DoSomethingElse(Action<int> action)
        {
            action(22);
            action(44);
        }
        public static void Print(int number, int numberSecond, int numberThird)
        {
            Console.WriteLine(number + numberSecond + numberThird);
        }
    }
}
