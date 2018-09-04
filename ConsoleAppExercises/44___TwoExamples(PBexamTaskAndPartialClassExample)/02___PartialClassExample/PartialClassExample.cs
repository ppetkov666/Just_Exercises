
namespace PartialClassExample
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    partial class PartialClassExample
    {
        public static void PrintFirst()
        {
            Console.WriteLine($"Hello {typeof(PartialClassExample).Name} i am the First Part");
        }
    }

}
