using System;

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company address: ");
            string address = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Company fax: ");
            string fax = Console.ReadLine();

            Console.Write("Company web site: ");
            string website = Console.ReadLine();

            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Manager age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.Write("Manager phone number: ");
            string managerNumber = Console.ReadLine();

            if (fax.Length < 7)
            {
                fax = "(no fax)";
            }

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("Web site: " + website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerNumber);
        }
    }
}
