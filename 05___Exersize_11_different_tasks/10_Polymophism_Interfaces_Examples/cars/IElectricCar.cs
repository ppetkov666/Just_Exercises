using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.cars
{
    interface IElectricCar : ICar
    {
        string batteryType { get; set; }
    }
}
