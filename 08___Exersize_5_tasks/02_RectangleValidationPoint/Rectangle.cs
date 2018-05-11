namespace _02_RectangleValidationPoint
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle()
        {
            this.TopLeft = new Point();
            this.BottomRight = new Point();
        }
        public void CreateRectangle(int x1, int y1, int x2, int y2)
        {
            this.TopLeft.X = x1;
            this.TopLeft.Y = y1;
            this.BottomRight.X = x2;
            this.BottomRight.Y = y2;
            
        }
        public bool CheckThePoint(Point point)
        {
            var inside = point.X >= TopLeft.X && point.X <= BottomRight.X
                && point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;
            return inside;
        }

    }
}
