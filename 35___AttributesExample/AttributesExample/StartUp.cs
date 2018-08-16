using System;

namespace AttributesExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var value = Permissions.Read | Permissions.Write;
            if (value.HasFlag(Permissions.Read))
            {
                Console.WriteLine("You can read");
            }
        }
    }
}
