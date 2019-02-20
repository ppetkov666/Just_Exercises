using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    class Circle
    {
        float _PI = 3.141F;
        int _Radius;

        public Circle(int radius)
        {
            this._Radius = radius;
        }
        public float CalculateArea()
        {
            return this._PI * this._Radius * this._Radius;
        }
    }
}
