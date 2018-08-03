namespace Random_Letter_Generator
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var randomClassExample = new Random();
            var counter = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {

                var number = randomClassExample.Next(1, 20);
                if (number == 1)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (i == 'Z')
                {
                    var newnumber = randomClassExample.Next(1, 26);
                    for (char a = 'A'; a <= 'Z'; a++)
                    {
                        counter++;
                        if (counter == newnumber)
                        {
                            Console.WriteLine(a);
                        }
                    }
                }
            }
        }
    }
}
