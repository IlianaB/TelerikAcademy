namespace _12.ExtractPricesLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractPricesLINQ
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../catalogue.xml");
            var prices =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2010
                select album.Element("price").Value;

            Console.WriteLine("Prices of albums published 5 years ago or earlier:");
            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
