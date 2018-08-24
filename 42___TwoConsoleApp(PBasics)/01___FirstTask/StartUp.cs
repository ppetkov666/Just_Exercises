using System;

namespace _11.programing_Basics_Task
{
    class StartUp
    {
        public const int StepsGoal = 10000;
        static void Main(string[] args)
        {

            string steps = Console.ReadLine();
            int counter = 0;
            int stepsAsInt;
            while (steps != "Going home")
            {
                
                bool isfalse = int.TryParse(steps, out stepsAsInt);
                counter += stepsAsInt;
                if (counter >= StepsGoal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    return;
                }
                steps = Console.ReadLine();
            }
            int lastSteps = int.Parse(Console.ReadLine());
            counter += lastSteps;
            if (counter >= StepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                return;
            }
            else
            {
                int neededSteps = StepsGoal - counter;
                Console.WriteLine($"{neededSteps} more steps to reach goal.");
            }
        }
    }
}
