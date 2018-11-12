
namespace Boolean_possible_Combination
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // the input must be space separated : 1 2 3 4 ......
            // the reason to type this code is because i needed to check how many possible combinations
            // i have if i have 3 boolean parameters which will be passed to stored procedure and
            // by which the querie will be Ordered By.
            var numbersForCheck = Console.ReadLine().Split().Select(int.Parse).ToList();
            GetAllPossibleCombinations(numbersForCheck);
        }
        static void GetAllPossibleCombinations(List<int> list)
        {

            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        Console.Write(list[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
