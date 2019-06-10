namespace Volatile_keyword_MultiThreading
{
    using System;
    using System.Threading;

    public class StartUp
    {
        private volatile bool _loop = true;
        static void Main(string[] args)
        {
            // we have unpredictable behavior in this example
            StartUp obj = new StartUp();
            // we create another thread
            Thread threadObject = new Thread(ThreadMethod);
            // and pass the parameter of the method which is object
            threadObject.Start(obj);

            Thread.Sleep(20);
            obj._loop = false;
            Console.WriteLine("Second Step - Change value of _loop to false");
        }

        private static void ThreadMethod(object obj)
        {
            
            StartUp objectOne = (StartUp)obj;
            Console.WriteLine("First Step - Entered the Loop");
            while (objectOne._loop)
            {

            }
            Console.WriteLine("Third step - Exited the loop");
        }
    }
   
}
