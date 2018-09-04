
namespace AbstractionAndInterfaces.Animals
{
    public class Bunny : Animal
    {
        public override string SayHello()
        {
            return base.SayHello() + string.Empty;
        }

    }
}
