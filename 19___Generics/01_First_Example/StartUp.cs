namespace _01_First_Example
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var tuple = ("petko", 5, 4.5);
            (var name, var age, var multy) = tuple;


            //indexer
            var myCustomClass = new MyCustomClass<int>();
            myCustomClass.Add(5);
            myCustomClass.Add(6);
            myCustomClass.Add(7);
            Console.WriteLine(myCustomClass.Count);
            var number = myCustomClass[0];
            myCustomClass[1] = 666;
            Console.WriteLine(number);
            Console.WriteLine(myCustomClass[1]);

            
            
        }

    }
}
