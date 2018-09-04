
namespace StaticVsNonStaticFieldsTest
{
    using System;
    using System.Diagnostics;
    class StartUp
    {
        const int max = 200000000;
        static void Main()
        {
            FirstTest test1 = new FirstTest(); // Instantiate instance fields
            SecondTest test2 = new SecondTest(); // Instantiate

            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                test1.X(); // Instance fields:
                test1.X();
                test1.X();
                test1.X();
                test1.X();
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                test2.X(); // Static fields:
                test2.X();
                test2.X();
                test2.X();
                test2.X();
            }
            s2.Stop();
            Console.WriteLine(s1.Elapsed.TotalMilliseconds);
            Console.WriteLine(s2.Elapsed.TotalMilliseconds);
            //When we create many FirstTest class instances, each will have its own copy of the fields.
            // When we  create many SecondTest instances, there will only be one copy of the fields in it.


        }
    }
}
