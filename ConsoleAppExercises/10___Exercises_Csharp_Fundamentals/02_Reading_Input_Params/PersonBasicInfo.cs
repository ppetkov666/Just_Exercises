namespace _02_Reading_Input_Params
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PersonBasicInfo
    {
        public string name;
        public string age;
        public string car;
        public List<Tire> carTires;
        public PersonBasicInfo(string name, string age, string car, List<Tire> tires)
        {
            this.name = name;
            this.age = age;
            this.car = car;
            this.carTires = tires;
        }
       
    }
}
