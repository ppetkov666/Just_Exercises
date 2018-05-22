using System;
using System.Linq.Expressions;

namespace _02_Second_Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Action<int> MyAction = Print;
            MyAction(100);
            MyAction += Sum;
            MyAction(100);
            MyAction += Multiply;
            MyAction(100);
            // it is different when we sum funk and actions
            Func<int, int> MyFunk = GetNumberPlusTen;
            Console.WriteLine(MyFunk(1000));
            MyFunk += GetNumberPlusTwenty;
            Console.WriteLine(MyFunk(1000));
            MyFunk += GetNumberPlusThirty;
            Console.WriteLine(MyFunk(1000));

            Console.WriteLine();
            AddThousand(MyAction);

            Expression<Func<int, int,int >> myEpressionFunk = (a, b) => (a + b);
            var expression = myEpressionFunk;
            Console.WriteLine(expression);
        }
        static void AddThousand(Action<int> action)
        {
            action(1000);
        }
        static void Print(int number)
        {
            Console.WriteLine(number);
        }
        static void Sum(int number)
        {
            Console.WriteLine(number + 10);
        }
        static void Multiply(int num)
        {
            Console.WriteLine(num * 10);
        }

        static int GetNumberPlusTen(int number)
        {
            return number + 10;
        }
        static int GetNumberPlusTwenty(int number)
        {
            return number + 20;
        }
        static int GetNumberPlusThirty(int number)
        {
            return number + 30;
        }
    }
}
