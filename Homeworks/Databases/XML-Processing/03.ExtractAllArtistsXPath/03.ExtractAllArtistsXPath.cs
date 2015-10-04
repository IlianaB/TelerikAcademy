using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.ExtractAllArtistsXPath
{
    class ExtractAllArtistsXPath
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
            XmlNodeList allAlbums = rootNode.SelectNodes("/catalogue/albums/album");
            Dictionary<string, int> uniqueAuthors = new Dictionary<string, int>();

            foreach (XmlNode album in allAlbums)
            {
                string artist = album["artist"].InnerText;

                if (uniqueAuthors.ContainsKey(artist))
                {
                    uniqueAuthors[artist]++;
                }
                else
                {
                    uniqueAuthors.Add(album["artist"].InnerText, 1);
                }
            }

            foreach (var pair in uniqueAuthors)
            {
                Console.WriteLine("Artist {0} has {1} album(s)!", pair.Key, pair.Value);
            }
        }
    }
}
