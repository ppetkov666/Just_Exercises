namespace _01_Very_Interesting_DIctionary_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            // key - name , value -> key - type of the card as integer from 1 to 4 and
            // value as hashset which is the power of the card !
            var personsWithCards = new Dictionary<string, Dictionary<int, HashSet<int>>>();

            while (input != "JOKER")
            {
                var inputArgs = input.Split(new char[] {':',',',' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                if (!personsWithCards.ContainsKey(name))
                {
                    personsWithCards.Add(name, new Dictionary<int, HashSet<int>>());
                    for (int i = 1; i <= 4; i++)
                    {
                        personsWithCards[name].Add(i, new HashSet<int>());
                    }
                }
                
                for (int i = 1; i < inputArgs.Length; i++)
                {
                    var card = inputArgs[i].Trim();
                    int cardPower = 0;
                    int cardType = 0;
                    if (card.Length > 2)
                    {
                         cardPower = GetCardPower(card.Substring(0, 2));
                         cardType = GetCrdType(card.Substring(2));
                    }
                    else
                    {
                         cardPower = GetCardPower(card.Substring(0,1));
                         cardType = GetCrdType(card.Substring(1));
                    }
                    personsWithCards[name][cardType].Add(cardPower);
                }
                input = Console.ReadLine();
            }

            foreach (var outerDict in personsWithCards)
            {
                var sum = 0;
                foreach (var innerDict in outerDict.Value)
                {
                    sum += innerDict.Key * innerDict.Value.Sum();
                }
                Console.WriteLine($"{outerDict.Key}: {sum}");
            }
        }

        private static int GetCardPower(string card)
        {
            switch (card)
            {
                case"J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(card);
                    
            }
        }

        private static int GetCrdType(string cardType)
        {
            switch (cardType)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return int.Parse(cardType);
                    
            }
        }
    }
}
