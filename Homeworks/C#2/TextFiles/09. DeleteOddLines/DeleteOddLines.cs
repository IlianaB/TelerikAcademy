using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _09.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            List<string> result = new List<string>();

            Console.WriteLine("File before removing odd lines: ");
            ReadFile(@"..\..\file.txt");

            using (StreamReader reader = new StreamReader(@"..\..\file.txt"))
            {
                int i = 0;
                string line = reader.ReadLine();                

                while (line != null)
                {
                    if (i % 2 == 1)
                    {
                        result.Add(line);
                    }
                    i++;
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\file.txt", false))
            {
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(result[i]);
                }
            }

            Console.WriteLine("Odd lines are deleted: ");
            ReadFile(@"..\..\file.txt");
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
