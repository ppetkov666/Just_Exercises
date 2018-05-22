namespace _01_FIrst_Example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {

            Func<string, int> MyParser = p => int.Parse(p);
            var numOfPeople = MyParser(Console.ReadLine());
            var persons = new Dictionary<string, int>(numOfPeople);
            for (int i = 0; i < numOfPeople; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var nameInput = input[0];
                var ageInput = int.Parse(input[1]);
                persons.Add(nameInput, ageInput);
            }
            var condition = Console.ReadLine();
            var age = MyParser(Console.ReadLine());
            var outputParams = Console.ReadLine();

            var funkCheker = Checker(condition, age);

            var checkPrinter = Printer(outputParams);

            FinalPrinter(persons, funkCheker, checkPrinter);

        }

        private static void FinalPrinter(Dictionary<string, int> persons, Func<KeyValuePair<string, int>, bool> funkCheker, Action<KeyValuePair<string, int>> checkPrinter)
        {
            foreach (var person in persons)
            {
                if (funkCheker(person))
                {
                    checkPrinter(person);
                }
            }
        }

        public static Func<KeyValuePair<string, int>, bool> Checker(string condition, int age)
        {
            if (condition == "older")
            {
                return p => p.Value >= age;
            }
            else
            {
                return p => p.Value < age;
            }
        }
        public static Action<KeyValuePair<string, int>> Printer(string output)
        {
            switch (output)
            {
                case "name":
                    return p => Console.WriteLine(p.Key);
                case "age":
                    return p => Console.WriteLine(p.Value);
                case "name age":
                    return p => Console.WriteLine($"{p.Key} - {p.Value}");
                default:
                    throw new NotImplementedException();
               
                   
            }
        }
    }

}
