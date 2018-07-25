namespace _02___SecondTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public const char OPEN_BRACKET = '(';
        public const char CLOSED_BRACKET = ')';
        public int GetSolution(string brackets)
        {
            int openCountBrackets = 0;
            int closingCountBrackets = 0;
            int bracketsLenght = brackets.Length;
            for (int i = 0; i < brackets.Length; i++)
            {
                char character = brackets[i];
                if (character == OPEN_BRACKET)
                {
                    openCountBrackets++;
                }
                else if (character == CLOSED_BRACKET)
                {
                    closingCountBrackets++;
                }
            }
            if (openCountBrackets == closingCountBrackets)
            {
                return openCountBrackets;
            }
            else
            {
                return closingCountBrackets;
            }
        }
    }
}
