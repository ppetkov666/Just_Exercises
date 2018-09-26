using System;
using System.Collections.Generic;
using MyExtension;
namespace Seven
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> filteredList = list.MyOwnFilter(n => n % 2 == 0);
            foreach (int item in filteredList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
