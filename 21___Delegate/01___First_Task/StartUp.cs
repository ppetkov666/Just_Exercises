using System;

namespace _01___First_Task
{
    public class StartUp
    {
        public delegate void TestDelegate();
        public delegate int ParsingInt(string input);
        static void Main(string[] args)
        {

            ParsingInt myCustomIntParseMethod = Parse;
            int number = myCustomIntParseMethod(Console.ReadLine());
            Console.WriteLine(number + 5);

            var myclass = new MyClass();
            myclass.LongRunning(CallBack);
        }
        public static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
        public void TestMethod()
        {
            Console.WriteLine("I am testing delegate");
        }
        public static int Parse(string input)
        {
            return int.Parse(input);
        }

    }
    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack callBack)
        {

            for (int i = 0; i < 101; i++)
            {
                callBack(i);
            }
        }
    }

}
