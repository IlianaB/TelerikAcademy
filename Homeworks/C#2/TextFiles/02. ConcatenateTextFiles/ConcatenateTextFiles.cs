using System;
using System.IO;
using System.Text;

//Write a program that concatenates two text files into another text file.

namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            using (var output = new StreamWriter(@"..\..\concaneted.txt", false))
            {
                foreach (var file in Directory.GetFiles(@"..\..\files", "*.*"))
                {
                    using (var input = new StreamReader(file))
                    {
                        output.WriteLine(input.ReadToEnd());
                    }
                }
            }

            Console.WriteLine("The content of concaneted two files is:");
            ReadFile(@"..\..\concaneted.txt");
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
