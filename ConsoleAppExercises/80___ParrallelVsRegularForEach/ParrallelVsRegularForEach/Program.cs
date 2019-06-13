using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParrallelVsRegularForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Stopwatch.StartNew();
            var count = NumberOfPrimeNumbers(2, 1000000);
            Console.WriteLine(count);
            Console.WriteLine(time.Elapsed);
            var parallelTime = Stopwatch.StartNew();
            var countParallel = NumberOfPrimeNumbersParallel(2, 1000000);
            Console.WriteLine(countParallel);
            Console.WriteLine(parallelTime.Elapsed);
        }
        static int NumberOfPrimeNumbers(int from, int to )
        {
            int count = 0;
            for (int a = from; a <= to; a++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    count++;
                }
            }
            
            return count;
        }

        static int NumberOfPrimeNumbersParallel(int from, int to)
        {
            int count = 0;
            // boxing 
            object obj = count;
            // unboxing
            // int counter = (int)obj;
            // parallel for is again consisted fo tasks !
            // if i dont lock the count we will get Race condition !
            Parallel.For(from, to + 1, (a) =>
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    //two different ways of locking
                    Interlocked.Increment(ref count);
                    //lock (obj)
                    //{
                    //    count++;
                    //}
                    
                }
            });
                
            

            return count;
        }
    }
}
