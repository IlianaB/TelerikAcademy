namespace _01_04.Point3D
{
    using System;
    using System.Text;

    public struct Point3D
    {
        //Field
        private static readonly Point3D pointO;

        //Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //pointO Property
        public static Point3D PointO
        {
            get { return pointO; }
        }

        //pointO constructor
        static Point3D()
        {
            pointO = new Point3D(0, 0, 0);
        }

        //Constructor
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Methods
        public override string ToString()
        {
            string result;
            result = string.Format("x = {0}, y = {1}, z = {2}", this.X, this.Y, this.Z);
            return result;
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
