

namespace CustomArraySort
{
    using System;
    using System.Collections;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var sortedLIst = CustomSort(input);
            foreach (var item in sortedLIst)
            {
                Console.WriteLine(item);
            }


        }
        public static IList CustomSort(IList arrayToSort)
        {
            int n = arrayToSort.Count - 1;
            for (int i = 0; i < n; i++)
            {

                for (int j = n; j > i; j--)
                {
                    if (((IComparable)arrayToSort[j - 1]).CompareTo(arrayToSort[j]) > 0)
                    {
                        object temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }
            return arrayToSort;
        }
    }
}
