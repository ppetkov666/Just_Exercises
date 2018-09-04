namespace _05_Validator
{
    public class Car
    { 
        public Car(int tires,string name)
        {
            this.Tires = tires;
            this.Name = name;
        }
        public int Tires { get; set; }
        public string Name { get; set; }

        public string Start()
        {
             Validator.CheckForNull(this.Name,nameof(Name));
            return "The name is Ok";
        }
    }
}
