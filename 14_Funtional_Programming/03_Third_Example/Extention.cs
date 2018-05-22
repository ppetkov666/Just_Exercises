namespace MyExtension

{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extention
    {
        public static List<int> MyOwnForeach(this List<int> list, Action<int> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
            return list;
        }
        public static ICollection<T> MyUniversalForeach<T> (this ICollection<T> list,
            Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
            return list;
        }
        public static bool IntChecker(this int number, Func<int,bool> function)
        {
           return function(number);
        }
        public static string StringToUpper(this string name,Func<string,string> funntion)
        {
            return funntion(name);
        }

    }
}
