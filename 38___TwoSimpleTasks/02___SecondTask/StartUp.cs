using System;

namespace _02___SecondTask
{
    class StartUp
    {
        public const double GoodGrade = 4.0;
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                double sum = 0;
                Boolean failed = false;
                for (int i = 1; i <= 12; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    if (grade < GoodGrade)
                    {
                        if (failed)
                        {
                            Console.WriteLine
                            ($"{input} has been excluded at {i} grade");
                            break;
                        }
                        failed = true;
                        i--;
                    }
                    else
                    {
                        failed = false;
                        sum += grade;
                    }
                }
                if (failed)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    double total = sum / 12;
                    Console.WriteLine($"{input} graduated. Average grade: {total:f2}");
                    input = Console.ReadLine();
                }

            }
        }
    }
}
