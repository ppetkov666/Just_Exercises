
namespace Memory_View_Solution
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            string initialInput = Console.ReadLine();
            StringBuilder storageHolder = new StringBuilder();
            while (initialInput != "Visual Studio crash")
            {
                storageHolder.Append(initialInput + " ");
                initialInput = Console.ReadLine();
            }
            string storageAsString = storageHolder.ToString();
            storageHolder.Clear();
            int[] finalArr = storageAsString
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < finalArr.Length - 5; i++)
            {
                if (finalArr[i] == 32656)
                {
                    int wordLength = finalArr[i + 4];
                    int beginWord = i + 6;
                    int endWord = beginWord + wordLength;
                    for (int j = beginWord; j <= endWord; j++)
                    {
                        storageHolder.Append((char)finalArr[j]);
                    }
                    storageHolder.AppendLine();
                }
            }
            storageHolder.Length--;
            Console.WriteLine(storageHolder);
        }
    }
}
