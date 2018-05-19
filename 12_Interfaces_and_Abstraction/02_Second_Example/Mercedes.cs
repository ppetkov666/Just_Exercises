using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Second_Example
{
    internal class Mercedes : Car,Icar
    {
        public override string StartEngine()
        {
            return base.StartEngine() + "Mercedes";
        }
    }
}
