using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.cars
{
    interface ICar
    {
        string Model { get;}
        void Start();
        void Stop();
    }
}
