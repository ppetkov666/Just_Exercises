namespace MyOwnExtension
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class MyExtensionMethod
    {
        public static void MyOwnForEach<T>(this ICollection<T> collection,
            Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
