using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Validator
    {
        public static void CheckForNull(object obj, string name = null)
        {
            if (obj == null)
            {
                throw new ArgumentException($"{name} cannot be null");
            }
        }
    }
}
