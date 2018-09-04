namespace _03_Counter
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            // first option
            for (int i = 0; i < 100000; i++)
            {
                Console.Write(i);
                Console.Write('\r');
            }
            Console.WriteLine("first counter ended");
            //second option 
            var num = 1;
            while (num != 100000)
            {

                Console.Write(num);
                Console.Write('\r');
                num++;
            }
            Console.WriteLine("second counter ended");
        }
    }
}
