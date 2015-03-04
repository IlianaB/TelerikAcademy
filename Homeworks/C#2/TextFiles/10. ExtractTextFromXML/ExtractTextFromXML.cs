using System;
using System.IO;
using System.Text;

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

namespace _10.ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            using (StreamReader streamReader = new StreamReader(@"../../input.xml"))
            {
                using (StreamWriter writer = new StreamWriter(@"../../output.txt", false))
                {
                    for (int i; (i = streamReader.Read()) != -1; )
                    {
                        if (i == '>')
                        {
                            StringBuilder text = new StringBuilder();

                            while (((i = streamReader.Read()) != '<') && i != -1)
                            {
                                text.Append((char)i);
                            }

                            string newText = Convert.ToString(text).Trim();

                            if (!String.IsNullOrWhiteSpace(newText))
                            {
                                writer.WriteLine(newText);
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Text from xml file is: ");
            ReadFile(@"../../output.txt");
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
