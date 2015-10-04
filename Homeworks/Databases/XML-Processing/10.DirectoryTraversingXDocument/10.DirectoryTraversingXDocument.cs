namespace _10.DirectoryTraversingXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class DirectoryTraversingXDocument
    {
        static void Main()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var myDocuments = TraverseDirectory(dir);
            myDocuments.Save("../../dir.xml");

            Console.WriteLine("You can see the result in dir.xml");
        }

        static XElement TraverseDirectory(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(TraverseDirectory(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("extension", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
