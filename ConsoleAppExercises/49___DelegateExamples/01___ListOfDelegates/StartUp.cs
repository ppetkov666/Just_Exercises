
namespace _01___ListOfDelegates
{
    using System;
    using System.Collections.Generic;

    public delegate void MyCustomDelegate();
    class StartUp
    {
        static void Main(string[] args)
        {
            List<MyCustomDelegate> listofDelegates = new List<MyCustomDelegate>();
            listofDelegates.Add(MyFirstMethod);
            listofDelegates.Add(MySecondMethod);
            listofDelegates.Add(MyThirdMethod);
            Console.WriteLine("------ First ------");
            for (int i = 0; i < listofDelegates.Count; i++)
            {
                listofDelegates[i]();
            }
            Console.WriteLine("------ Second ------");
            List<MyCustomDelegate> secondListOfDelegates = new List<MyCustomDelegate>();
            MyCustomDelegate test = new MyCustomDelegate(MyFirstMethod);
            test += MySecondMethod;
            test += MyThirdMethod;
            secondListOfDelegates.Add(test);
            foreach (var item in secondListOfDelegates)
            {
                item();
            }

            Console.WriteLine("------ Third ------");
            MyCustomDelegate mytestDelegate = new MyCustomDelegate(MyFirstMethod);
            mytestDelegate += MySecondMethod;
            mytestDelegate += MyThirdMethod;
            mytestDelegate();


        }

        public static void MyFirstMethod() {Console.WriteLine("My First Method");}
        public static void MySecondMethod() { Console.WriteLine("My Second Method"); }
        public static void MyThirdMethod() { Console.WriteLine("My Third Method"); }

    }

}
