namespace _02___Dead_lock
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
           {
               Console.WriteLine("Entering Step A");
               Thread.Sleep(1000);
               lock ("first")
               {
                   Console.WriteLine("A got first lock");
                   Thread.Sleep(1000);
                   lock ("second")
                   {
                       Console.WriteLine("A got a second lock");
                       
                   }
               }
               Console.WriteLine("Exiting Step A");
           });

            Task.Run(() =>
            {
                Console.WriteLine("Entering Step B");
                Thread.Sleep(1000);
                lock ("second")
                {
                    Console.WriteLine("B got second lock");
                    Thread.Sleep(1000);
                    lock ("first")
                    {
                        Console.WriteLine("B got a first lock");
                    }
                }
                Console.WriteLine("Exiting Step B"); 
            });
            while (true)
            {

            }
        }
    }
}
