namespace _01_04.Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        //Field
        private List<Point3D> pointsSequence;

        //Constructor
        public Path()
        {
            this.pointsSequence = new List<Point3D>();
        }

        //Property
        public List<Point3D> PointsSequence
        {
            get { return pointsSequence; }
        }

        //Method
        public void AddPoint3D(Point3D point)
        {
            this.pointsSequence.Add(point);
        }

    }
}
