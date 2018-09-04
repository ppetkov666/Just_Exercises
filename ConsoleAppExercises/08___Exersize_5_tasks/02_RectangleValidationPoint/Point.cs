namespace _02_RectangleValidationPoint
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(Func<string> readPoint)
        {
            var secondPointInput = readPoint().Split().Select(int.Parse).ToArray();
            X = secondPointInput[0];
            Y = secondPointInput[1];
        }
    }
}
