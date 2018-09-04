namespace SimpleHackTask
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            // this task is how to switch between two states of bool variable without if statement 
            // the comment ternary operator is if statement actually but it is just a another example how it can be done 
            // the actual solution is  xor-equals true !!!
            bool value = bool.Parse(Console.ReadLine());
            value ^= true;
            //value = (value) ? false : true;
            Console.WriteLine(value);

        }
    }
}
