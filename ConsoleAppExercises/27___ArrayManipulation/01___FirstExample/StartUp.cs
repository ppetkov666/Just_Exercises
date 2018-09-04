using System;

namespace _01___FirstExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //var customArray = new MyCustomArray<int>(20);
            //customArray[0] = 10;
            //customArray[1] = 20;
            //customArray[2] = 30;
            //customArray[3] = 40;
            //customArray.Add(4, 400);
            //for (int i = 0; i < customArray.Length; i++)
            //{
            //    if (customArray[i] > 0)
            //    {
            //        Console.WriteLine(customArray[i]);
            //    }
            //}
            var numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            var newArray = PetkoMethodToRemoveAt(numbers, 5);
            Console.WriteLine();
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
        private static int[] PetkoMethodToRemoveAt(int[] myArray, int RemoveAt)
        {
            int[] newArray = new int[myArray.Length - 1];

            int i = 0;
            int j = 0;
            while (i < myArray.Length)
            {
                if (i != RemoveAt)
                {
                    newArray[j] = myArray[i];
                    j++;
                }

                i++;
            }

            return newArray;
        }
    }
}
