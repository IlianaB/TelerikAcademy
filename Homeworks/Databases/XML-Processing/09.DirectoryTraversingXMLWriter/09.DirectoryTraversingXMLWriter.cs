namespace _09.DirectoryTraversingXMLWriter
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class DirectoryTraversingXMLWriter
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../dir.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                writer.WriteStartDocument();
                writer.WriteStartElement("current-directory");
                TraverseDirectory(path, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("You can see the result in dir.xml");
        }

        private static void TraverseDirectory(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                TraverseDirectory(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("extension", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
