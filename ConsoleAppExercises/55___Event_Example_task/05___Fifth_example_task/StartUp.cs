using System;

namespace _05___Fifth_example_task
{
    public class StartUp
    {
        public event EventHandler MyEvent;
       //{
       //    add
       //    {
       //        Console.WriteLine("add operation");
       //    }
       //
       //    remove
       //    {
       //        Console.WriteLine("remove operation");
       //    }
       //}
        static void Main(string[] args)
        {
            StartUp test = new StartUp();
            test.MyEvent += new EventHandler(MyFirstMethod);
            test.MyEvent += MySecondMethod;
            test.MyEvent += MyThirdMethod;
            test.MyEvent("petko",EventArgs.Empty);
            Console.WriteLine("------------------");
            test.OnMyEvent();
            Console.WriteLine("------");
            Test anotherTest = new Test();
            anotherTest.MySecondEvent += MyFirstMethod;
            anotherTest.MySecondEvent += MySecondMethod;
            anotherTest.MySecondEvent += MyThirdMethod;
            anotherTest.OnMySecondEvent();
            Console.WriteLine("---");
            Test sdfds = new Test();
            

        }
        public static void MyFirstMethod(object sender, EventArgs e) { Console.WriteLine("My First Method Event Test"); }
        public static void MySecondMethod(object sender, EventArgs e) { Console.WriteLine("My Second Method Event Test"); }
        public static void MyThirdMethod(object sender, EventArgs e) { Console.WriteLine("My Third Method Event Test"); }

        protected virtual void OnMyEvent()
        {
            MyEvent(this, EventArgs.Empty);
        }

    }
    public class Test
    {
        public event EventHandler MySecondEvent;

        public delegate void MyCustomEventHandler();
        public void OnMySecondEvent()
        {
            MySecondEvent(this, EventArgs.Empty);
        }
    }
}
