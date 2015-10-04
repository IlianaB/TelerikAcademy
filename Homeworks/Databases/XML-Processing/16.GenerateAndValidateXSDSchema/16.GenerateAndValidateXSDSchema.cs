namespace _16.GenerateAndValidateXSDSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class GenerateAndValidateXSDSchema
    {
        static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../catalogue.xsd");

            XDocument validXML = XDocument.Load("../../catalogue.xml");
            XDocument invalidXML = XDocument.Load("../../invalidCatalogue.xml");

            PrintValidationResult(validXML, schema, "catalogue.xml");
            PrintValidationResult(invalidXML, schema, "invalidCatalogue.xml");
        }

        private static void PrintValidationResult(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine("* {0} * {1}", file, ev.Message);
            });
        }
    }
}
