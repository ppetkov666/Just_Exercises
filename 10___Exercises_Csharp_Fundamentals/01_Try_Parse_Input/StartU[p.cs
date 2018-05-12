namespace _01_Try_Parse_Input
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var name = "Default Name";
            var age = -1;
            if (input.Length == 2)
            {
                name = input[0];
                age = int.Parse(input[1]);
                Console.WriteLine($"I am {name},{age} years old");
            }
            else if (input.Length == 1)
            {
                var isAge = int.TryParse(input[0], out age);
                if (!isAge)
                {
                    name = input[0];
                    Console.WriteLine($"I am {name}");
                    return;
                }
                Console.WriteLine($"i am {age} old");
            }
            
        }
        
    }
    
}
