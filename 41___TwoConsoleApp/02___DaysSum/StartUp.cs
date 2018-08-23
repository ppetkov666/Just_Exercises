namespace DaysSum
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
           
            string format2 = "dd";
            //string date1 = Console.ReadLine();
            //string date2 = Console.ReadLine();

            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


            //DateTime input1 = DateTime.Parse(date1);
            //DateTime input2 = DateTime.Parse(date2);

            int counter1 = 0;
            int counter2 = 0;


            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    counter1++;
                }
                else if (i % 2 != 0)
                {
                    counter2++;
                }
            }
            string addDay1 = date1.AddDays(counter1).ToString(format2);
            string addDay2 = date2.AddDays(counter2).ToString(format2);

            int d1 = int.Parse(addDay1);
            int d2 = int.Parse(addDay2);

            Console.WriteLine(d1 + d2);
        }
    }
}