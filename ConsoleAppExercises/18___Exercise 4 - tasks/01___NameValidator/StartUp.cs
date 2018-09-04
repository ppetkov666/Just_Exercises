namespace _01___NameValidator
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] name = input.Split();
            var nameLenght = name.Length;
            var secondNameFirstLetter = name[1][0];
            var firstNameFirstLetter = name[0][0];

            if (nameLenght == 2
                & char.IsUpper(firstNameFirstLetter)
                & char.IsUpper(secondNameFirstLetter))
            {
                Console.WriteLine("Name format is correct");
                Console.WriteLine($"First name is {name[0].Length} letters long");
                Console.WriteLine($"Last name is {name[1].Length} letters long");
                Console.WriteLine($"First name, first letter is capital {firstNameFirstLetter}");
                Console.WriteLine($"Last name, first letter is capital {secondNameFirstLetter}");

            }
            else
            {
                Console.WriteLine("Name Format is WRONG");
            }

        }
    }
}
