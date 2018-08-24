using System;
using System.Globalization;
namespace _12___ProgramingBasicTask
{
    class StartUp
    {
        public const int DateCount = 2;
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] daysStorage = new int[DateCount];

            for (int i = 0; i < DateCount; i++)
            {
                string input = Console.ReadLine();
                string outputFormat = "dd-MM-yyyy";
                DateTime parsedInput = DateTime.ParseExact(input, outputFormat, CultureInfo.InvariantCulture);
                DateTime days = new DateTime();
                int counter = 0;
                if (i == 0)
                {
                    for (int a = 1; a <= number; a++)
                    {
                        if (a % 2 == 0)
                        {
                            counter++;
                        }

                    }
                    days = parsedInput.AddDays(counter);
                }
                else
                {
                    for (int a = 1; a <= number; a++)
                    {
                        if (a % 2 != 0)
                        {
                            counter++;
                        }

                    }
                    days = parsedInput.AddDays(counter);
                }
                daysStorage[i] = days.Day;
            }
            int sum = 0;
            for (int i = 0; i < daysStorage.Length; i++)
            {
                sum += daysStorage[i];
            }
            Console.WriteLine(sum);
           
        }
    }
}
