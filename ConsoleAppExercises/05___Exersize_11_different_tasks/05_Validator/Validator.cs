namespace _05_Validator
{
    using System;

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
