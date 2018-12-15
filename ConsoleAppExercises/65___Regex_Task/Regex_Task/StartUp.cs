
namespace Regex_Task
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string regex = @"<([a-z][0-9]*)([a-z][0-9]*)*>";

            Regex washingTheDishesPattern = new Regex(regex);

            int washingDishesTime = 0;

            while (command != "wife is happy")
            {

                Match dishesMatch = washingTheDishesPattern.Match(command);

                if (dishesMatch.Success)
                {
                    string array = dishesMatch.Value;
                    char[] converted = array.ToCharArray();
                    for (int i = 0; i < converted.Length; i++)
                    {
                        char letter = converted[i];
                        if (char.IsDigit(letter))
                        {
                            int numericValue = (int)Char.GetNumericValue(letter);
                            washingDishesTime += numericValue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Doing the dishes {washingDishesTime}");
        }
    }
}
