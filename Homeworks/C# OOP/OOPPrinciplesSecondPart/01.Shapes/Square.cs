namespace _01.Shapes
{
    using System;

    class Square : Shape
    {
        //Constructors
        public Square(double width, double height) :base(width, height)
        {
        }

        public Square(double side) :base(side, side)
        {
        }

        //Properties
        public override double Height
        {
            get
            {
                return base.Height;
            }
            protected set
            {
                if (value != this.Width)
                {
                    throw new ArgumentException("The height of the square must be the same as its width!");
                }

                base.Height = value;
            }
        }

        //Methods
        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }
    }
}
