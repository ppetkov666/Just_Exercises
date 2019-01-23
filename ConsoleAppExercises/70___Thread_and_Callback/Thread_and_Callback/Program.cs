using System;
using System.Threading;

namespace Thread_and_Callback
{
    public delegate void CalculateNumbers(int numbers);
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            CalculateNumbers callback = new CalculateNumbers(CallbackCalculate);
            Calculate calculateNum = new Calculate(number, callback);
            Thread thread = new Thread(calculateNum.CalculateSum);
            thread.Start();
            string text = "Please wait while your request is being proceeded";
            Console.WriteLine(text);
        }
        public static void CallbackCalculate(int num)
        {
            Console.WriteLine($"The sum of numbers is {num.ToString()}"); 
            
        }
    }
}
