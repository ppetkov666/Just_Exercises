namespace _01___FirstTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        public const int MIN_INPUT_NUMBER = 0;
        public const int MAX_INPUT_NUMBER = 100_000_000;
        public const int FIRST_OPTION = 1;
        public const int SECOND_OPTION = 2;
        public void Run()
        {
            int solutionOption = GetSolutionOption();
            if (solutionOption == FIRST_OPTION)
            {
                PrintDefaultSolution();
            }
            // this is my way , it could get even more complicated but for the purpose
            // of this homework i think it's enough
            else
            {
                PrintOptimalSolution();
            }
        }
        private static void PrintOptimalSolution()
        {
            int firstNumber, secondNumber;
            GetValidatedInputNumbers(out firstNumber, out secondNumber);
            // this is just for an example without making instance of the Class
            // that is why i am using static class
            OptionalSolution.Solution(firstNumber, secondNumber);
        }

        private static void GetValidatedInputNumbers(out int firstNumber, out int secondNumber)
        {
            string printFirstMessage = $"Enter the First number within the range [{MIN_INPUT_NUMBER} - {MAX_INPUT_NUMBER}]";
            string printSecondMessage = $"Enter the Second number within the range [{MIN_INPUT_NUMBER} - {MAX_INPUT_NUMBER}]";
            firstNumber = GetValidatedNumber(printFirstMessage);
            secondNumber = GetValidatedNumber(printSecondMessage);
        }

        private static void PrintDefaultSolution()
        {
            int firstNumber, secondNumber;
            GetValidatedInputNumbers(out firstNumber, out secondNumber);

            DefaultSolution defaultSolution = new DefaultSolution();
            int positiveBits = defaultSolution.Solution(firstNumber, secondNumber);
            Console.WriteLine($"The number of positive bits is {positiveBits}");
        }

        private static int GetSolutionOption()
        {
            int solutionInput;
            while (true)
            {
                Console.WriteLine($"For Default Solution Press {FIRST_OPTION}, " +
                                  $"for Optional Solution Press {SECOND_OPTION}");
                solutionInput = int.Parse(Console.ReadLine());

                if (solutionInput != FIRST_OPTION && solutionInput != SECOND_OPTION)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return solutionInput;
        }
        private static int GetValidatedNumber(string printMessage)
        {
            int inputNumber;
            while (true)
            {
                Console.WriteLine(printMessage);
                Boolean isParsed = int.TryParse(Console.ReadLine(), out inputNumber);

                if (inputNumber < MIN_INPUT_NUMBER | inputNumber > MAX_INPUT_NUMBER | isParsed == false)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return inputNumber;
        }
    }
}

