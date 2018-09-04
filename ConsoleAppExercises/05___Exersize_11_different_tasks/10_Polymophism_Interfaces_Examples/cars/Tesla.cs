using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.cars
{
    class Tesla : IElectricCar
    {
        public string batteryType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Model => throw new NotImplementedException();

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
