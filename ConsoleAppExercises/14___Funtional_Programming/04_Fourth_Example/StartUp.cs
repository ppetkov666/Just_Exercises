namespace _04_Fourth_Example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            // the difference between Where and Select is the return Type
            var listOfNums = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var sortedlistWhere = listOfNums.Where(x => x % 2 == 0);
            var sortedlistSelect = listOfNums.Select(x => x % 2 == 0);
            var sortedAdd = listOfNums.Select(x => $"number is:{x}");

            sortedlistWhere.ToList().ForEach(x => Console.WriteLine(x));
            sortedlistSelect.ToList().ForEach(x => Console.WriteLine(x));
            sortedAdd.ToList().ForEach(x => Console.WriteLine(x));
            // thist will simulate how the user ask for certain page in the browser
            // and choose the the size of the page
            var pageInfo = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Enter Page number and Size");
            while (true)
            {
                var page = int.Parse(Console.ReadLine());
                var pageSize = int.Parse(Console.ReadLine());
                if (page * pageSize > pageInfo.Count)
                {
                    var showContent = pageInfo.Skip(pageSize * (page - 1)).Take(pageSize);
                    foreach (var item in showContent)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    var showContent = pageInfo.Skip(pageSize * (page - 1)).Take(pageSize);
                    foreach (var item in showContent)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
