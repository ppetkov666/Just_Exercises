namespace _03_Third_Example
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            // this is just an example what is under "property get and set in C#"
            TestClass testName = new TestClass();
            testName.SetName("petko");
            Console.WriteLine(testName.GetName());

            // this is example of polymophism with list, array and hashset, 
            // and Icollection
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            var array = new int[]
                {
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                };

            var hashset = new HashSet<int>();
            hashset.Add(14);
            hashset.Add(15);
            hashset.Add(16);
            hashset.Add(17);
            hashset.Add(18);
            hashset.Add(19);
            hashset.Add(20);

            Print(list);
            Print(array);
            Print(hashset);
        }
        public static void Print(ICollection<int> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }

}
