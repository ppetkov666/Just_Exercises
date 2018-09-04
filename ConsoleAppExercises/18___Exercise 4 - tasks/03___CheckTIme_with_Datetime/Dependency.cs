namespace _03___CheckTIme_with_Datetime
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Dependency
    {
        public static string CheckTime(DateTime date)
        {
            if (date.Hour < 12)
            {
                return "Good Morning";
            }
            else if (date.Hour >= 12 & date.Hour < 20)
            {
                return "Good Day";
            }
            else
            {
                return "Good Afternoon";
            }
        }
    }
}
