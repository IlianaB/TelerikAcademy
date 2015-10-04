using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.DeleteAlbumsWithPriceHigherThan20
{
    class DeleteAlbumsWithPriceHigherThan20
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue.xml");
            XmlElement rootNode = doc.DocumentElement;
            var allAlbums = rootNode.GetElementsByTagName("album");


        }
    }
}
