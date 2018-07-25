namespace _02___SecondTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        public const int FIRST_OPTION = 1;
        public const int SECOND_OPTION = 2;
        public void Run()
        {
            Console.WriteLine("Enter the String of Brackets");
            string brackets = Console.ReadLine();
            int solutionOption = GetSolutionOption();
            if (solutionOption == FIRST_OPTION)
            {
                Solution solution = new Solution();
                int searchedIntegerK = solution.GetSolution(brackets);
                Console.WriteLine(searchedIntegerK);
            }
            else
            {
                OptionalSolution optimalSolution = new OptionalSolution();
                optimalSolution.GetOptionalSolution(brackets);
            }
        }
        private static int GetSolutionOption()
        {
            int solutionOption;
            while (true)
            {
                Console.WriteLine($"For Default Solution Press {FIRST_OPTION}, " +
                                  $"for Optional Solution Press {SECOND_OPTION}");
                solutionOption = int.Parse(Console.ReadLine());
                if (solutionOption != FIRST_OPTION && solutionOption != SECOND_OPTION)
                {
                    Console.WriteLine("Wrong Number ! ");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return solutionOption;
        }
    }
}
