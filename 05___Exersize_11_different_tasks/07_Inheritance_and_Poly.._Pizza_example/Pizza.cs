namespace Pizza
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Pizza
    {
        public string name;
        public string flavor;

        public Pizza(string name, string flavor)
        {
            this.name = name;
            this.flavor = flavor;
        }
        public abstract void BakeIt();
        
        
    }
}
