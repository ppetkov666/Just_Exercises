

namespace _02_DelegatesAndEvents
{
    using System;
    public delegate void MyClass_Delegate();
    public class StartUp
    {
        static void Main(string[] args)
        {
            MyFirstTestClass firstClass = new MyFirstTestClass();
            firstClass.Click = Hello;
            firstClass.Click += HowAreYou;
            firstClass.TestMethod();

            MySecondClass.SecondStaticTestMethod(NiceToMeetYou);
            
        }
        // these are three static methods just for the example purposes
        private static void Hello() { Console.WriteLine("Hello"); }
        private static void HowAreYou() { Console.WriteLine("How Are You"); }
        private static void NiceToMeetYou() { Console.WriteLine("Nice To Meet You"); }
    }
    public class MyFirstTestClass
    {
        public MyClass_Delegate Click {get;set;} // member variable or field or instance variable from type Delegate

        // this method has member variable from type delegate inside 
        public void TestMethod()
        {
            Click();
        }
    }
    public class MySecondClass
    {
        
        // this method takes delegate as parameter
        public static void SecondStaticTestMethod(MyClass_Delegate click)
        {
            click();
        }
    }
}
