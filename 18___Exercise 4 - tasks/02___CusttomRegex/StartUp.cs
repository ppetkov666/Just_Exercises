namespace _02___CusttomRegex
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            var example = "petko<petkov>123";
            bool inState = false;
            bool outstate = true;
            StringBuilder str = new StringBuilder();
            foreach (var character in example)
            {
                if (inState)
                {
                    if (character == '>')
                    {
                        outstate = true;
                        inState = false;
                    }
                }
                else if (outstate)
                {
                    if (character == '<')
                    {
                        outstate = false;
                        inState = true;
                    }
                    else
                    {
                        str.Append(character);
                    }
                }
            }
            Console.WriteLine(str);
        }
    }
}
