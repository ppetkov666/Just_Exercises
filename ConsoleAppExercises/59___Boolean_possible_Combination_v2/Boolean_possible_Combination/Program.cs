
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
            var numbersForCheck = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();
            
            List<string> storage = GetAllPossibleCombinations(numbersForCheck);
            Console.WriteLine($"You have {storage.Count} possible combinations");
            foreach (var numbers in storage)
            {
                Console.WriteLine($"parameter {numbers} - checked");
            }

        }
        static List<string> GetAllPossibleCombinations(List<int> list)
        {
            List<string> storageList = new List<string>();
            string current = string.Empty;
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        if (j == str.Length - 1)
                        {
                            current += list[j];
                        }
                        else
                        {
                            current += list[j] + ", ";
                        }
                    }
                }
                current = current.Trim(' ');
                if (current.EndsWith(','))
                {
                    current = current.Remove(current.Length - 1);
                }
                storageList.Add(current);
                current = string.Empty;
            }
            storageList.Sort();
            return storageList;
        }
    }
}
