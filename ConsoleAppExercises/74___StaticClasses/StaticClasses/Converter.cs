using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    public static class Converter
    {
        public static double _FahrenheitMultiplier = 1.800;
        public static double _CelciusMultiplier = 0.555;

        public static double ToFahrenheit(double celcius)
        {
            return (celcius * _FahrenheitMultiplier + 32);
        }
        public static double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * _CelciusMultiplier;
        }
    }
}
