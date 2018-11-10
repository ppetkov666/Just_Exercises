namespace SoftUni_contest_exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // key - name , value -> key - type of the card as integer from 1 to 4 and
            // value as hashset which is the power of the card !
            Dictionary<string, Dictionary<int, HashSet<int>>> personsWithCards = new Dictionary<string, Dictionary<int, HashSet<int>>>();

            while (input != "JOKER")
            {
                string[] inputArgs = input.Split(':').ToArray();
                string name = inputArgs[0];
                string[] cards = inputArgs[1]
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (!personsWithCards.ContainsKey(name))
                {
                    personsWithCards.Add(name, new Dictionary<int, HashSet<int>>());
                    for (int i = 1; i <= 4; i++)
                    {
                        personsWithCards[name].Add(i, new HashSet<int>());
                    }
                }

                for (int i = 0; i < cards.Length; i++)
                {
                    string card = cards[i].Trim();
                    int cardPower = 0;
                    int cardType = 0;
                    if (card.Length > 2)
                    {
                        cardPower = GetCardPower(card.Substring(0, 2));
                        cardType = GetCardType(card.Substring(2));
                    }
                    else
                    {
                        cardPower = GetCardPower(card.Substring(0, 1));
                        cardType = GetCardType(card.Substring(1));
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
            int returnedNumber = 0;
            if (card == "J") returnedNumber = 11;
            else if (card == "Q") returnedNumber = 12;
            else if (card == "K") returnedNumber = 13;
            else if (card == "A") returnedNumber = 14;
            else int.TryParse(card, out returnedNumber);
            return returnedNumber;
        }

        private static int GetCardType(string cardType)
        {
            int returnedNumber = 0;
            if (cardType == "S") returnedNumber = 4;
            else if (cardType == "H") returnedNumber = 3;
            else if (cardType == "D") returnedNumber = 2;
            else if (cardType == "C") returnedNumber = 1;
            else int.TryParse(cardType, out returnedNumber);
            return returnedNumber;
        }
    }
}
