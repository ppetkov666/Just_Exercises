namespace IncreaseAgeOfaPerson
{
    using System;
    class StartUp
    {
        const int AgeForRetire = 65;
        static void Main()
        {
            var person = new Person(66);
            if (person.Age > AgeForRetire)
            {
                Console.WriteLine(person.TimeToRetire());
                return;
            }
            person.IncreaseAgeByOneYear().Print();
        }
    }
}