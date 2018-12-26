using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LinkedLIstExamples
{
    class StartUp
    {
        const int max = 100000;
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("cat");
            linkedList.AddLast("dog");
            linkedList.AddLast("man");
            linkedList.AddFirst("first");
            
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            LinkedListNode<string> linkedListV2 = linkedList.Find("first");
            linkedList.AddAfter(linkedListV2, "after first");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--- comparing list and linked list time");

            List<string> list = new List<string>();
            LinkedList<string> link = new LinkedList<string>();
            
            for (int i = 0; i < 1000; i++)
            {
                list.Add("test");
                link.AddLast("test");
            }
            Stopwatch s1 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                foreach (string v in list)
                {
                    if (v.Length != 4)
                    {
                        throw new Exception();
                    }
                }
            }
            s1.Stop();
            Stopwatch s2 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                foreach (string v in link)
                {
                    if (v.Length != 4)
                    {
                        throw new Exception();
                    }
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
        }
    }
}
