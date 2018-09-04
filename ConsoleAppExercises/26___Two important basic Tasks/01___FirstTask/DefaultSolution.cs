namespace _01___FirstTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DefaultSolution
    {
        public int Solution(int firstNumber, int secondNumber)
        {
            
            int result = firstNumber * secondNumber;
            // here i made my own Method to convert 
            return MyOwnConvertMethod(result);

        }
        public int MyOwnConvertMethod(int result)
        {
            int counter = 0;
            while (result > 0)
            {
                if (result % 2 != 0)
                {
                    counter++;
                }
                result /= 2;
            }
            return counter;
        }
    }
}
