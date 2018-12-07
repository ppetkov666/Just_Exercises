
namespace twoQuestionMarkOperatorVsTernary
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            // i will demonstrate 3 different cases just to show the output 
            // of ternary operator and "??" operator comparing one another 
            string ternaryResult = null;
            string twoQuestionMarkResult = null;
            string test = Console.ReadLine();

            if (test == string.Empty)
            {
                ternaryResult = test != null ? "ternary operator: is it empthy string" : "ternary operator: null string";
                twoQuestionMarkResult = test ?? "?? operator: null string";
                PrintOutput(ternaryResult, twoQuestionMarkResult);
            }
            else if (test == "just regular string")
            {
                ternaryResult = test != null ? "ternary operator: just regular string" : "ternary operator: null string";
                twoQuestionMarkResult = test ?? "?? operator: null string";
                PrintOutput(ternaryResult, twoQuestionMarkResult);
            }
            else
            {
                test = null;
                ternaryResult = test != null ? "ternary operator: not null string" : "ternary operator: null string";
                twoQuestionMarkResult = test ?? "?? operator: null string";
                PrintOutput(ternaryResult, twoQuestionMarkResult);
            }
        }
        private static void PrintOutput(string ternaryResult, string twoQuestionMarkResult)
        {
            Console.WriteLine(ternaryResult);
            Console.WriteLine(twoQuestionMarkResult);
        }
    }
}
