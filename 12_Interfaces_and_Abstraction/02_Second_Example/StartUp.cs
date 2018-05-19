using System;
using System.Collections;
using System.Collections.Generic;
namespace _02_Second_Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            var listOfCars = new List<Car>();
            Car mercedes = new Mercedes();
            Car tesla = new Tesla();

            listOfCars.Add(mercedes);
            listOfCars.Add(tesla);
            foreach (var item in listOfCars)
            {
                if (item is IelectricCar)
                {
                    Console.WriteLine(item.StartElectricEngine());
                }
                else
                {
                    Console.WriteLine(item.StartEngine());
                }
                
            }

            IEnumerable list = new List<int>();
            // this is valid cast
            List<int> newlist = (List<int>)list;
            // in this cast will return null instead to throw an exception
            var anotherList = list as HashSet<int>;
            // in this case will throw an exception
            //var anotherList2 = (HashSet<int>)list;

        }
        
    }
}
