namespace _02___SecondTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OptionalSolution
    {
        public const char OPEN_BRACKET = '(';
        public const char CLOSED_BRACKET = ')';
        public void GetOptionalSolution(string brackets)
        {
            int openCountBrackets = 0;
            int closingCountBrackets = 0;
            int bracketsLenght = brackets.Length;
            MyCustomArray<bool> arrayOfOpenBrackets = new MyCustomArray<bool>(brackets.Length);
            MyCustomArray<bool> arrayOfClosedBrackets = new MyCustomArray<bool>(brackets.Length);
            
            for (int i = 0; i < brackets.Length; i++)
            {
                char character = brackets[i];
                if (character == OPEN_BRACKET)
                {
                    openCountBrackets++;
                    arrayOfOpenBrackets[i] = true;

                }
                else if (character == CLOSED_BRACKET)
                {
                    closingCountBrackets++;
                    // i am just using another method to add into array on a specific position
                    arrayOfClosedBrackets.Add(i,true);
                }
            }
            if (openCountBrackets == closingCountBrackets)
            {
                Console.WriteLine($"The searched integer K is equal to {openCountBrackets}");
            }
            else
            {
                Console.WriteLine($"The searched integer K is equal to {closingCountBrackets}");
            }
            
            // here i create a stringbuiler where i keep indexes and because i separate them 
            // with "," on the last index i dont want to finish with ",".That's why 
            // i use the method Remove , and when i go out of For loop 
            // i simple remove the last ',' and because this method does not return new variable 
            // i just use the current  stringbuilder.
            if (openCountBrackets == 0)
            {
                Console.WriteLine("There are no Open Brackets");
            }
            else
            {
                Console.Write("There is an Open Bracket on Index: ");
                StringBuilder openBracketIndexes = new StringBuilder();
                for (int i = 0; i < arrayOfOpenBrackets.Length; i++)
                {
                    if (arrayOfOpenBrackets[i] == true)
                    {
                        openBracketIndexes.Append($"{i}, ");
                    }
                }
                openBracketIndexes.Remove(openBracketIndexes.Length - 2,2);
                Console.WriteLine(openBracketIndexes);
            }
            if (closingCountBrackets == 0)
            {
                Console.WriteLine("There are no Closing Brackets");
            }
            else
            {
                Console.Write("There is an Closed Bracket on Index: ");
                StringBuilder closedBracketIndexes = new StringBuilder();
                for (int i = 0; i < arrayOfClosedBrackets.Length; i++)
                {
                    if (arrayOfClosedBrackets[i] == true)
                    {
                        closedBracketIndexes.Append($"{i}, ");
                    }
                }
                closedBracketIndexes.Remove(closedBracketIndexes.Length - 2, 2);
                Console.WriteLine(closedBracketIndexes);
            }  
        }
    }
}
