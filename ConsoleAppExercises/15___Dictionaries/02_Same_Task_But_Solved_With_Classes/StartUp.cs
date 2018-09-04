namespace _02_Same_Task_But_Solved_With_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            
            var personList = new List<Person>();
            var input = Console.ReadLine();
            while (input != "JOKER")
            {
                var inputArgs = input
                    .Split(new char[] { ':', ',', ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                
                if (!personList.Any(p=>p.Name == name))
                {
                    var person = new Person();
                    person.Name = name;
                    for (int i = 1; i < inputArgs.Length; i++)
                    {
                        var card = inputArgs[i];
                        person.Cards.Add(card);
                    }
                    personList.Add(person);
                }
                else
                {
                    for (int i = 1; i < inputArgs.Length; i++)
                    {
                        var card = inputArgs[i];
                        var persontoAddCard = personList.First(p => p.Name == name);
                        persontoAddCard.Cards.Add(card);
                    }
                }
                input = Console.ReadLine();
            }
          
            foreach (var person in personList)
            {
                foreach (var eachcard in person.Cards)
                {
                    var cardPower = "";
                    var cardTypePower = "";
                    var cardPowerasInt = 0;
                    var cardTypePowerAsInt = 0;
                    var cardValue = 0;
                    string card = eachcard.Trim();
                    if (card.Length > 2)
                    {
                        cardPower = card.Substring(0, 2);
                        cardTypePower = card.Substring(2);
                        cardPowerasInt = GetPoints(cardPower);
                        cardTypePowerAsInt = GetCardTypePower(cardTypePower);
                        cardValue = cardPowerasInt * cardTypePowerAsInt;
                        person.Points += cardValue;

                    }
                    else
                    {
                        cardPower = card.Substring(0, 1);
                        cardTypePower = card.Substring(1);
                        cardPowerasInt = GetPoints(cardPower);
                        cardTypePowerAsInt = GetCardTypePower(cardTypePower);
                        cardValue = cardPowerasInt * cardTypePowerAsInt;
                        person.Points += cardValue;
                    }
                }
            }
            foreach (var person in personList)
            {
                Console.WriteLine($"{person.Name}: {person.Points}");
            }
            
        }
        private static int GetCardTypePower(string cardTypePower)
        {
            switch (cardTypePower)
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
                    return int.Parse(cardTypePower);
            }
        }
        private static int GetPoints(string point)
        {
            switch (point)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(point);   
            }
        }
    }
}
