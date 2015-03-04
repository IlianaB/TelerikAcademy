using System;
using System.IO;
using System.Text;

//Write a program that reads a text file and prints on the console its odd lines.

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\file.txt"))
            {
                int i = 0;
                string line = reader.ReadLine();
                StringBuilder result = new StringBuilder();

                while (line != null)
                {
                    if (i % 2 == 1)
                    {
                        result.AppendLine(line);
                        result.AppendLine();
                    }
                    i++;
                    line = reader.ReadLine();
                }

                Console.WriteLine(result);
            }
        }
    }
}
