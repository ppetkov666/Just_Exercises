namespace _01___First_Example
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            // this is hidden dependency because when i initialize the car i have no idea that car depend from class V6Engine
            // when i use the keyword NEW  i have a hidden dependency
            // i also implemented the solution how to be avoided
            Car car = new Car();


            // the problem with this method is that i cannot test it 
            // i have dependency from datetime and from console
            Greet();
            // i have the same problem here with dependency - cannot test it for specific result.
            // If i want to test it i have to start it numerous times untill i see all results, but what about if i have 
            // 200 if/ else with  awards- is becomes almost impossible
            CheckContest();
            

            // this is the right way things to be done 
            // no hidden dependency , and i can check it easily 
            DateTime morning = new DateTime(2016,1,1,10,0,0);
            DateTime afternoon = new DateTime(2016, 1, 1, 16, 0, 0);
            DateTime evening = new DateTime(2016, 1, 1, 20, 0, 0);
            Console.WriteLine(GreetSecondVersion(morning));
            Console.WriteLine(GreetSecondVersion(afternoon));
            Console.WriteLine(GreetSecondVersion(evening));

            // the same example with the other method
            Console.WriteLine(CheckContestSecondVersion(20));
            Console.WriteLine(CheckContestSecondVersion(40));
            Console.WriteLine(CheckContestSecondVersion(60));
            Console.WriteLine(CheckContestSecondVersion(80));
            // and random also can be tested 
            Console.WriteLine(new Random().Next());

        }

        public static void Greet()
        {
            DateTime now = DateTime.Now;
            if (now.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (now.Hour > 12 && now.Hour < 19)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        }

        public static string GreetSecondVersion(DateTime date)
        {
            
            if (date.Hour < 12)
            {
                return "Good Morning";
            }
            else if (date.Hour > 12 && date.Hour < 19)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good evening";
            }
        }

        public static void CheckContest()
        {
            Random random = new Random();
            double number = random.Next(0, 100);

            if (number < 30)
            {
                Console.WriteLine("you win 50 usd");
            }
            else if (number > 30 && number < 60 )
            {
                Console.WriteLine("you win 100 usd");
            }
            else
            {
                Console.WriteLine("try again later");
            }
        }

        public static string CheckContestSecondVersion(int number)
        {
            if (number < 30)
            {
                return "you win 50 usd";
            }
            else if (number > 30 && number < 60)
            {
                return "you win 100 usd";
            }
            else
            {
                return "try again later";
            }
        }
    }
}
