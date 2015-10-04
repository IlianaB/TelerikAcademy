namespace _07.CreateNewXMLDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class CreateNewXMLDocument
    {
        static void Main()
        {
            string name, phone, address;

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                name = reader.ReadLine();
                phone = reader.ReadLine();
                address = reader.ReadLine();
            }

            XElement person = new XElement("person",
                new XElement("name", name),
                new XElement("phone", phone),
                new XElement("address", address)
                );

            person.Save("../../person.xml");
            Console.WriteLine("Person saved as person.xml - see the file.");
        }
    }
}
