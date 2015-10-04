namespace _06.ExtractSongTitlesWithXDocumentAndLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractSongTitlesWithXDocumentAndLINQ
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../catalogue.xml");
            var root = xmlDoc.Element("catalogue");

            var titles =
                from song in root.Descendants("song")
                select song.Element("title").Value;

            Console.WriteLine("All songs' titles in the catalogue: ");
            foreach (var title in titles)
            {
                Console.WriteLine("- {0}", title);
            }
        }
    }
}
