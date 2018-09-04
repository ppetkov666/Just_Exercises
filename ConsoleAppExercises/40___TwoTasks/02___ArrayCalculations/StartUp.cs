using System;
using System.Linq;

namespace ConsoleApp4
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];

                    for (int k = 0; k <= array.Length - 1; k++)
                    {
                        if (array[k] == sum)
                        {
                            Console.WriteLine("{0} + {1} == {2}", array[i], array[j], sum);
                            counter++;
                            break;
                        }
                    }
                   
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
