using System;
using System.Collections.Generic;
using System.Linq;
namespace dictionary_simple_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string data = Console.ReadLine();

                if (data == "end")
                {
                    break;
                }

                string[] input = data.Split().ToArray();

                string country = input[0];
                string city = input[1];
                int numberOfCitizens = int.Parse(input[2]);


                if (dictionary.ContainsKey(country) == false)
                {
                    dictionary.Add(country, new Dictionary<string, int>());
                }

                if (dictionary[country].ContainsKey(city) == false)
                {

                    dictionary[country][city] = numberOfCitizens;
                }

            }




            foreach (var state in dictionary )
            {
                Console.WriteLine($"{state.Key}");

                foreach (var kvp in state.Value)
                {
                    string town = kvp.Key;
                    int residents = kvp.Value;

                    if (residents > 10000)
                    {
                        Console.WriteLine($"{town} - {residents}");
                    }
                    else
                    {
                        Console.WriteLine($"{town}");
                    }
                }
            }

        }
    }
}
