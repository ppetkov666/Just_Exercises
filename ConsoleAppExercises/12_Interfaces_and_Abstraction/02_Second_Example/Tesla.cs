using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Second_Example
{
    class Tesla : Car,IelectricCar
    {
        public override string StartElectricEngine()
        {
            return base.StartElectricEngine() + "Tesla engine start differently";
        }
    }
}
