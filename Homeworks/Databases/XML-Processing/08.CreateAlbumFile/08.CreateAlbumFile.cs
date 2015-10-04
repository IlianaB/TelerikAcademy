namespace _08.CreateAlbumFile
{
    using System;
    using System.Text;
    using System.Xml;

    class CreateAlbumFile
    {
        static void Main()
        {
            string fileName = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("UTF-8");

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element))
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            else if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }

            Console.WriteLine("The result is saved in album.xml");
        }
    }
}
