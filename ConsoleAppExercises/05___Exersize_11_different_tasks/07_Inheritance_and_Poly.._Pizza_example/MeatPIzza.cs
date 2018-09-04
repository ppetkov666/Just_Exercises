namespace Pizza
{
    using System;
    public class MeatPIzza : Pizza
    {

        public MeatPIzza(string name, string flavor) : base(name, flavor)
        {

        }
        public override void BakeIt()
        {
            Console.WriteLine("45 min on 220 C degree");
        }
    }
}
