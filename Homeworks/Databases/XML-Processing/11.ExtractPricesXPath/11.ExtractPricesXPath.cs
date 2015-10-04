namespace _11.ExtractPricesXPath
{
    using System;
    using System.Xml;

    class ExtractPricesXPath
    {
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");
            string xPathQuery = "/catalogue/album[year<2010]";
            XmlNodeList allAlbums = xmlDoc.SelectNodes(xPathQuery);

            Console.WriteLine("Prices of albums published 5 years ago or earlier:");
            foreach (XmlNode album in allAlbums)
            {
                string albumname = album.SelectSingleNode("name").InnerText;
                string albumPrice = album.SelectSingleNode("price").InnerText;
                Console.WriteLine("Album: {0}, Price: {1}", albumname, albumPrice);
            }
        }
    }
}
