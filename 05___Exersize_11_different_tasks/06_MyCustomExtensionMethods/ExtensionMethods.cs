namespace _06_MyCustomExtensionMethods
{
    using System;
    using System.Collections.Generic;
    public static class ExtensionMethods
    {
       public static string MyPersonalTrim(this string input)
       {
            return input.Trim('-');
       }
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
