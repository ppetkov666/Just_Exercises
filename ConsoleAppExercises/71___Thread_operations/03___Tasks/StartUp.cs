namespace _03___Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class StartUp
    {
        public delegate void PrintNumbersDelegate(List<int> num);
        static void Main(string[] args)
        {
            // this task is just for demonstation, in real world scenario the things looks little bit different
            // because of the purpose of this exercise you can print the results in 4 different ways

            List<int> sampleParam = Enumerable.Range(0, 1000).ToList();
            // first one
            //PrintNumbersAsync(sampleParam);

            // second one
            //PrintNumbersDelegate printerDelegate = new PrintNumbersDelegate(PrintNumbersViaDelegate);
            //printerDelegate.Invoke(sampleParam);

            // third one
            //Printer printer = new Printer();
            //printer.PrintEvent += Printer_PrintEvent;
            //printer.StartPrinting();

            // fourth one - this approach is the way how usually the things has to be done
            PrintNumbersAsyncV2(sampleParam);

            // this part of the code is just to simulate user interface
            Console.WriteLine("User interface is started");
            while (true)
            {
                Console.ReadLine();
            }
        }

        private static async void Printer_PrintEvent(object sender, EventArgs e)
        {
            Dictionary<int, double> numbers = await PrintNumbersViaEvent(Enumerable.Range(0, 1000).ToList());
            PrintingResults(numbers);
        }

        public static void PrintNumbersAsync(List<int> numbers)
        {
            GetsquareRootsAsync(numbers).ContinueWith(
                (results) =>
                {
                    if (results.IsFaulted)
                    {
                        Console.WriteLine(results.Exception);
                    }
                    foreach (var item in results.Result)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                });
        }

        public static async void PrintNumbersAsyncV2(List<int> numbers)
        {
            Dictionary<int, double> table =  await GetsquareRootsAsync(numbers);
            try
            {
            PrintingResults(table);
            }
            catch (Exception e)
            {
                throw new AggregateException(e.Message);
            }

        }

        public static async void PrintNumbersViaDelegate(List<int> numbers)
        {
            Dictionary<int, double> nums = await GetsquareRootsAsync(numbers);
            foreach (var item in nums)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public static async Task<Dictionary<int, double>> PrintNumbersViaEvent(List<int> numbers)
        {
            Dictionary<int, double> nums = await GetsquareRootsAsync(numbers);
            return nums;
        }

        public static Task<Dictionary<int, double>> GetsquareRootsAsync(List<int> numbers)
        {
            // i am just presenting 2 diff options
            Task<Dictionary<int, double>> nums = Task.Run(
                () => { return GetSquareRoots(numbers); }
            );

            //Task<Dictionary<int, double>> nums1 = Task.Run(
            //    () => (GetSquareRoots(numbers))
            //);

            return nums;
        }

        public static Dictionary<int, double> GetSquareRoots(List<int> numbers)
        {
            Dictionary<int, double> squareRootDict = new Dictionary<int, double>();

            foreach (var num in numbers)
            {
                Thread.Sleep(10);
                squareRootDict[num] = Math.Sqrt(num);
            }
            return squareRootDict;
        }

        private static void PrintingResults(Dictionary<int, double> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
