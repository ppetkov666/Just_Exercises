namespace _04___Regex_matchevaluator
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main(string[] args)
        {
            //  TWO DIFFERENT OPTIONS HOW TO USE MATCHEVALUATOR
            //1. WITH METHOD PASING TO LAMBDA 
            //2. WITHOUT METHOD , JUST LAMBDA FUNCTION AND SWITCH()

            string pattern = @"[0-9]";
            string input = @"petko12345";

            var result = Regex.Replace(input, pattern, (s) => ReplaceNums(s));
            //{
            //    switch (s.Value)
            //    {
            //        case "1":
            //            return "{one}";
            //        case "2":
            //            return "{two}";
            //        case "3":
            //            return "{three}";
            //        case "4":
            //            return "{four}";
            //        case "5":
            //            return "{five}";
            //        case "6":
            //            return "{six}";
            //        default:
            //            throw new ArgumentException();
            //    }
            //});
            Console.WriteLine(result);
        }
        public static string ReplaceNums(Match s)
        {

            switch (s.Value)
            {
                case "1":
                    return "{one}";
                case "2":
                    return "{two}";
                case "3":
                    return "{three}";
                case "4":
                    return "{four}";
                case "5":
                    return "{five}";
                case "6":
                    return "{six}";
                default:
                    throw new ArgumentException();
            }
        }
    }
}
