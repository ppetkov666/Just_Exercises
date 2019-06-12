using System;

namespace ConsoleApp1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Example object_one = new Example();
            object_one.number = 1;
            object_one.word = "one";

            Example object_two = new Example();
            object_two.number = 2;
            object_two.word = "two";

            Example object_three = new Example();
            object_three = object_one + object_two;

            Console.WriteLine(object_three.number);
            Console.WriteLine(object_three.word);
        }
    }
    public class Example
    {
        public int number;
        public string word;

        public static Example operator +(Example obj_1, Example obj_2)
        {
            Example obj_3 = new Example();
            obj_3.number = obj_1.number + obj_2.number;
            obj_3.word = obj_1.word + obj_2.word;
            return obj_3;
        }
    }
}
