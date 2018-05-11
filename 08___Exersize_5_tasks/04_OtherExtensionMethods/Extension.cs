
namespace _04_OtherExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extension
    {
        public static string PrintDefaultMessageAfterNumber(this int input)
        {
            var output = $"{input} miles away from home";
            return output;
        }
        public static string PrintDefaultMessage( int input)
        {
            var output = $"{input} miles away from home";
            return output;
        }

    }
}
