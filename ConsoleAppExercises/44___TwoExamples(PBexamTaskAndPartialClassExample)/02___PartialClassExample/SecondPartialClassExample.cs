using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassExample
{
    partial class PartialClassExample
    {
        public static void PrintSecond()
        {
            Console.WriteLine($"Hello {typeof(PartialClassExample).Name}, i am the Second part");
        }
    }
}
