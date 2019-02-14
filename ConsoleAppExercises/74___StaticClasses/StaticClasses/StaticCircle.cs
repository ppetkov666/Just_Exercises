namespace StaticClasses
{
    class StaticCircle
    {
        public static float _PI; //= 3.141F;
        int _Radius;

        // static constructor cannot have access modifiers and any time we refer to any field in the class
        // it will be called automatically so even we dont need explicitlly to call it
        // it is created ONLY ONCE no matter how many instances we create !!!!
        // is it called before instance constructors
        static StaticCircle()
        {
            System.Console.WriteLine("Static constructor called only once");
            StaticCircle._PI = 3.141F;
        }
        public StaticCircle(int radius)
        {
            System.Console.WriteLine("Instance constructor called");
            _Radius = radius;
        }
        public float CalculateArea()
        {
            
            return _PI * this._Radius * this._Radius;
        }
    }
}
