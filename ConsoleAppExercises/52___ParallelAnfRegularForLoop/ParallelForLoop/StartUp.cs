using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ParallelForLoop
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<int> numbers = Enumerable.Range(0, 100000).ToList();

            Stopwatch t = new Stopwatch();
            t.Start();
            Parallel.For(0, numbers.Count, (index, ParallelLoopState) =>
                  {
                      if (numbers[index] == 12)
                      {
                          Console.WriteLine($"Number {numbers[index]} found at position {index}");

                      }

                      Console.WriteLine($"Number {index} is processed by thread Id {Thread.CurrentThread.ManagedThreadId}");

                  }
                  );
            Console.WriteLine("--------------the end of the Parallel For--------------");
            t.Stop();
            Console.WriteLine(t.Elapsed);

            t.Start();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 12)
                {
                    Console.WriteLine($"Number {numbers[i]} found at position {i}");

                }

                Console.WriteLine($"Number {i} is processed by thread Id {Thread.CurrentThread.ManagedThreadId}");
            }
            Console.WriteLine("--------------the end of the Regular For--------------");
            t.Stop();
            Console.WriteLine(t.Elapsed);
        }
    }
}
