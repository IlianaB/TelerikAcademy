namespace _01_04.Point3D
{
    using System.IO;

    class PathStorage
    {
        public static void SavePath(Path path, string pathIdentifier) 
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {
                for (int i = 0; i < path.PointsSequence.Count; i++)
                {
                    sw.WriteLine(path.PointsSequence[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint3D(nextPoint);
                }
            }

            return path;
        }
    }
}
