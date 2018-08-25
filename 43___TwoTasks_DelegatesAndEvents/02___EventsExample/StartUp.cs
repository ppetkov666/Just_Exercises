
namespace _03___Events
{
    using System;
    public delegate void MyDelegate(string name);
    class StartUp
    {
        static void Main(string[] args)
        {

            MyFirstClass firstClassExample = new MyFirstClass();
            firstClassExample.myEvent += Hello;
            firstClassExample.myEvent += HowAreYou;
            firstClassExample.TestMethod();

            MySecondClass secondClassExample = new MySecondClass();
            secondClassExample.myevent += SecondClassExample_myevent;
            secondClassExample.TestMethod();

        }

        private static void SecondClassExample_myevent(object sender, EventArgs e)
        {
            NiceToMeetYou();
        }

        private static void Hello(string name) { Console.WriteLine($"Hello {name}"); }
        private static void HowAreYou(string name) { Console.WriteLine($"How Are You {name}"); }
        private static void NiceToMeetYou() { Console.WriteLine("Nice To Meet You"); }
    }
    public class MyFirstClass
    {
        public event MyDelegate myEvent;
        public void TestMethod()
        {
            if (myEvent != null)
            {
                myEvent("petko");
            }
        }
    }
    public class MySecondClass
    {
        public event EventHandler<EventArgs> myevent;
        public void TestMethod()
        {
            if (myevent != null)
            {
                myevent(this, new EventArgs());
            }
        }
    }
}
