namespace _01___First_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Car
    {
        private readonly IEngine _engine;
        //private readonly V6Engine engine;

        public Car() 
            :this(new V6Engine())
        {

        }
        public Car(IEngine engine)
        {
            this._engine = engine;
            //this.engine = new V6Engine();
        }
    }
}
