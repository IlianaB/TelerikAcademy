namespace _01_04.Point3D
{
    using System;

    public static class CalculateDistance
    {
        public static double CalcDistance(Point3D point1, Point3D point2)
        {
            double distance;
            distance = Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X)
                               + (point1.Y - point2.Y) * (point1.Y - point2.Y)
                               + (point1.Z - point2.Z) * (point1.Z - point2.Z));

            return distance;
        }
    }
}
