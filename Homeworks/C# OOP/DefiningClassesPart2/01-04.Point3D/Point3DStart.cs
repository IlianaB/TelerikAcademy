namespace _01_04.Point3D
{
    using System;

    class Point3DStart
    {
        static void Main()
        {
            Point3D startPoint = new Point3D(2, 3, 4);
            Point3D endPoint = new Point3D(4, 5, 10);
            Console.WriteLine("The distance between start point with coords: \n{0}\nand end point with coords: \n{1}\nis {2:0.00} cm.", 
                startPoint, endPoint, CalculateDistance.CalcDistance(startPoint, endPoint));

            Path testPath = new Path();
            testPath.AddPoint3D(startPoint);
            testPath.AddPoint3D(endPoint);

            PathStorage.SavePath(testPath, "sample"); 

            Path loadedPath = PathStorage.LoadPath(@"../../pathsample.txt");

            Console.WriteLine("Points saved in the points sequence path are: ");

            for (int i = 0; i < loadedPath.PointsSequence.Count; i++)
            {
                Console.Write("Point{0}: ", i + 1);
                Console.WriteLine(loadedPath.PointsSequence[i]);
            }

        }
    }
}
