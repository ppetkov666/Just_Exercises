namespace _02_Reflection_Speed
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            var listofCats = new List<Cat>();
            for (int i = 0; i < 100000; i++)
            {
                var cat = (Cat)Activator.CreateInstance(typeof(Cat), "Tom");
                listofCats.Add(cat);
            }
            Console.WriteLine(listofCats.Count);
            timer.Stop();
            Console.WriteLine(timer.Elapsed);

            Stopwatch timer1 = Stopwatch.StartNew();
            timer1.Start();
            var listofCats1 = new List<Cat>();
            for (int i = 0; i < 100000; i++)
            {
                var cat = new Cat("tom");
                listofCats1.Add(cat);
            }
            Console.WriteLine(listofCats1.Count);
            timer1.Stop();
            Console.WriteLine(timer1.Elapsed);
            
        }
    }
}
