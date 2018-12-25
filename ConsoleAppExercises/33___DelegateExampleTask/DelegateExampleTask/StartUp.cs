namespace DelegateExampleTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        public delegate void SomeMethodPointer();
        public List<char> alphaBet = new List<char>();
        static void Main(string[] args)
        {
            //  i will explne why the explanation that Delegete is just a pointer to a Function it is not correct
            //  first i create object from type delegate and points to SomeMethod
            SomeMethodPointer obj = new SomeMethodPointer(SomeMethod);
            obj.Invoke();
            // the question here is why i have to call this method through delegate(INdirectly) and not just directly to call SomeMethod
            // like this : SomeMethod()

            // the real use of delegates is callback ... 
            //to take a method of one class which is CallBack(int i) 
            //and to pass another method from other class as parameter through delegate !!!!
            MyClass objSecondVersion = new MyClass();
            objSecondVersion.LongRunning(CallBack);
            MyClass secondExample = new MyClass();
            secondExample.AlphaBet(AlphaBet);
        }
        static void SomeMethod()
        {
            Console.WriteLine("Method Called...");
        }
        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
        static void AlphaBet(char letter)
        {
            Console.Write(letter);
            Console.Write(' ');
        }
    }
    public class MyClass
    {
        public delegate void CallBack(int i);
        public delegate void AnotherCallBack(char letter);
        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 100; i++)
            {
                // does something
                obj(i);
            }
        }

        public void AlphaBet(AnotherCallBack alphabet)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {

                alphabet(i);
            }
        }
    }

}
