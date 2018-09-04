

namespace AbstractionAndInterfaces.Animals
{
    public class Dog : Animal
    {
        public override string SayHello()
        {
            return base.SayHello() + "Bay";
        } 
    }
}
