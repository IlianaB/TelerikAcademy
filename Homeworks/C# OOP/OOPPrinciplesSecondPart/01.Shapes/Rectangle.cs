﻿namespace _01.Shapes
{
    class Rectangle : Shape
    {
        //Constructors
        public Rectangle(double width, double height) :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }
    }
}
