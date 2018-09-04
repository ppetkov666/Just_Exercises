namespace DelegateExampleTask
{
    using System;
    class StartUp
    {
        public delegate void SomeMethodPointer();
        static void Main(string[] args)
        {
            //  i will explne why the explanation that Delegete is just a pointer to a Function it is not correct
            //  first i create object from type delegate and points to SomeMethod
            SomeMethodPointer obj = new SomeMethodPointer(SomeMethod);
            obj.Invoke();
            // the question here is why i have to call this method through delegate(INdirectly) and not just directly to call SomeMethod
            // like this : SomeMethod()

            // the real use of delegates is callback ... 
            //to take a method of one class which is MyClass.LongRunning() and to pass another method from other class as parameter through delegate !!!!
            MyClass objSecontVersion = new MyClass();
            objSecontVersion.LongRunning(CallBack);
        }
        static void SomeMethod()
        {
            Console.WriteLine("Method Called...");
        }
        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }
    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 100; i++)
            {
                // does something
                obj(i);
            }
        }
    }

}
