namespace _01.Shapes
{
    class Triangle : Shape
    {
        //Constructors
        public Triangle(double width, double height) :base(width, height)
        {
        }

        //Methods
        public override double CalculateSurface()
        {
            return ((this.Width * this.Height) / 2);
        }
    }
}
