namespace _02_Reading_Input_Params
{

    public class Tire
    {
        private int pressure;
        private int size;
        public Tire(int pressure, int size)
        {
            this.Pressure = pressure;
            this.size = size;
        }
        public int Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
    }
}
