namespace Pizza
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var listOfPizzas = new List<Pizza>();
            listOfPizzas.Add(new MeatPIzza("meat with Bakon ","BAKON"));
            listOfPizzas.Add(new MeatPIzza("meat with P","PEPERONI"));
            listOfPizzas.Add(new VegeterianPizza("veggie Pizza","MOZARELLA"));

            foreach (var item in listOfPizzas)
            {
                item.BakeIt();
                Console.WriteLine(item.name);
                Console.WriteLine(item.flavor);
            }
        }
    }
}
