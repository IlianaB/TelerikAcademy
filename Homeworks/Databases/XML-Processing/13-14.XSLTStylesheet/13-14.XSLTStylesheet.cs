using System;

namespace _13_14.XSLTStylesheet
{
    using System.Xml.Xsl;

    class XSLTStylesheet
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../style.xslt");
            xslt.Transform("../../catalogue.xml", "../../catalogue.html");

            Console.WriteLine("You can see the result in catalogue.html");
        }
    }
}
