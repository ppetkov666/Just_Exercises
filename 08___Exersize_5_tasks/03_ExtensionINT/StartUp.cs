namespace _03_ExtensionINT
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int money = 100;
            Console.WriteLine(money.PrintMoney());
            var input = " petko ";
            Console.WriteLine(input.TrimCustomMethod());  
        }
    }
    public static class MyExtension
    {
        public static string PrintMoney(this int money)
        {
            return money.ToString("f2");
        }
        public static string TrimCustomMethod(this string input)
        {
            var output = input.Trim();
            return output;
        }
    }

}
