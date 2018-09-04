using System;

namespace _01_First_Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // this is interesting example how and why we use "this" 
            // it is not about validation , it is just for the purpose of 
            // of this specific example
            var age = int.Parse(Console.ReadLine());
            var person = new CustomClass();
            if (person.SetAge(age))
            {
                // when we return the same object in the method
                // we can chain more than one method !
                person.Print();
                person.IncreaseAgeByOne().PrintIncreasedYears();
                
            }
            
        }
    }
}
