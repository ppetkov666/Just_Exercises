namespace ConsoleApp1
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int examhour = int.Parse(Console.ReadLine());
            int examminute = int.Parse(Console.ReadLine());
            int arrivinghour = int.Parse(Console.ReadLine());
            int arrivingminute = int.Parse(Console.ReadLine());

            int examsum = (examhour * 60) + examminute;
            int arrsum = (arrivinghour * 60) + arrivingminute;

            int late = arrsum - examsum;
            int ontime = examsum - arrsum;

            int hour = 0;
            int min = 0;

            if (late > 59)
            {
                hour = late / 60;
                min = late % 60;
                string minAsString = min.ToString();
                string formatedMin = minAsString.ToString().PadLeft(2, '0');
                Console.WriteLine("Late");
                Console.WriteLine($"{hour}:{formatedMin} hours after the start");
            }
            else if (late > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{late} minutes after the start");
            }

            else if (ontime == 0) Console.WriteLine("On time");
            else if (ontime <= 30)
            {
                Console.WriteLine("On Time");
                Console.WriteLine($"{ontime} minutes before the start");
            }
            else if (ontime > 30)
            {

                if (ontime > 59)
                {
                    hour = ontime / 60;
                    min = ontime % 60;
                    string minAsString = min.ToString();
                    string formatedMin = minAsString.ToString().PadLeft(2, '0');
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hour}:{formatedMin} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{ontime} minutes before the start");
                }
            }
        }
    }
}
