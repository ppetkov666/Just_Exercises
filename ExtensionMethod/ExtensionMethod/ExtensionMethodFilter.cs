using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtension
{
    public static class ExtensionMethodFilter
    {
        public static IEnumerable<T> MyOwnFilter<T>
            (this List<T> collection, Func<T, bool> input)
        {
            var output = new List<T>();
            foreach (var item in collection)
            {
                if (input(item))
                {
                    output.Add(item);
                }
            }
            return output;
        }
    }
}
