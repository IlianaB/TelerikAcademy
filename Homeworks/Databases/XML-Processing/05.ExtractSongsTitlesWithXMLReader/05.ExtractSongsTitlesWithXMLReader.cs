using System.Collections.Generic;

namespace _05.ExtractSongsTitlesWithXMLReader
{
    using System;
    using System.Xml;

    class ExtractSongsTitlesWithXMLReader
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
            {
                List<string> allSongs = new List<string>();

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        allSongs.Add(reader.ReadElementString());
                    }
                }

                Console.WriteLine("All songs' titles in the catalogue: ");
                foreach (var song in allSongs)
                {
                    Console.WriteLine("- {0}", song);
                }
            }
        }
    }
}
