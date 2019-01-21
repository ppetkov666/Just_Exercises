using System;
using System.Threading;

namespace Thread_protect_resources
{
    public class Program
    {
        static int total = 0;
        static void Main(string[] args)
        {
            Thread threadOne = new Thread(AddMilion);
            Thread threadTwo = new Thread(AddMilion);
            Thread threadThree = new Thread(AddMilion);
            threadOne.Start();
            threadTwo.Start();
            threadThree.Start();
            threadOne.Join();
            threadTwo.Join();
            threadThree.Join();
            Console.WriteLine($"total: {total}");
        }
        static object _lock = new object();
        public static void AddMilion()
        {
            for (int i = 0; i < 10000000; i++)
            {
                //total++;
                //Interlocked.Increment(ref total);
                lock (_lock)
                {
                    total++;
                }
            }
        }
    }
}
