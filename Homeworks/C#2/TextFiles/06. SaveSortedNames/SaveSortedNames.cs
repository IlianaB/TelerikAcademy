using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	output.txt
//Ivan          George
//Peter         Ivan 
//Maria         Maria 
//George	    Peter


namespace _06.SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            using (StreamReader streamReader = new StreamReader(@"..\..\input.txt"))
            {
                string line = streamReader.ReadLine();
                List<string> people = new List<string>();

                while (line != null)
                {
                    people.Add(line);
                    line = streamReader.ReadLine();
                }
                people.Sort();

                using (StreamWriter streamWriter = new StreamWriter(@"..\..\output.txt"))
                {
                    foreach (string person in people)
                    {
                        streamWriter.WriteLine(person);
                    }
                }
            }

            Console.WriteLine("People names are sorted: ");
            ReadFile(@"..\..\output.txt");
        }

        private static void ReadFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                StringBuilder result = new StringBuilder();

                while (line != null)
                {
                    result.AppendLine(line);
                    line = reader.ReadLine();
                }

                Console.WriteLine(result);
            }
        }
    }
}
