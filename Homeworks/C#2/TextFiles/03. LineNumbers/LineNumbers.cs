using System;
using System.IO;
using System.Text;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\file.txt"))
            {
                string line = reader.ReadLine();                
                int lineNum = 0;

                using (StreamWriter writer = new StreamWriter(@"..\..\fileWithNumbers.txt", false))
                {
                    while (line != null)
                    {
                        lineNum++;
                        writer.WriteLine("Line {0}: {1}", lineNum, line);
                        line = reader.ReadLine();
                    }
                }
            }

            Console.WriteLine("File is with line numbers now: ");
            ReadFile(@"..\..\fileWithNumbers.txt");
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
