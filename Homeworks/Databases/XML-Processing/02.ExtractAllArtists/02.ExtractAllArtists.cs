using System;
using System.Collections.Generic;
using System.Xml;

namespace _02.ExtractAllArtists
{
    public class ExtractAllArtists
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue.xml");
            XmlElement rootNode = doc.DocumentElement;
            var allAlbums = rootNode.GetElementsByTagName("album");
            Dictionary<string, int> uniqueAuthors = new Dictionary<string, int>();

            foreach (XmlNode node in allAlbums)
            {
                string artist = node["artist"].InnerText;

                if (uniqueAuthors.ContainsKey(artist))
                {
                    uniqueAuthors[artist]++;
                }
                else
                {
                    uniqueAuthors.Add(node["artist"].InnerText, 1);
                }
            }

            foreach (var pair in uniqueAuthors)
            {
                Console.WriteLine("Artist {0} has {1} album(s)!", pair.Key, pair.Value);
            }
        }
    }
}
