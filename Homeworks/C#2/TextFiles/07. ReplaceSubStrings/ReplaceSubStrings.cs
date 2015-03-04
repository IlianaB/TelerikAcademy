using System;
using System.IO;
using System.Text;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

namespace _07.ReplaceSubStrings
{
    class ReplaceSubStrings
    {
        static void Main()
        {
            using (StreamReader streamReader = new StreamReader(@"../../input.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter(@"../../output.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        streamWriter.WriteLine(line.Replace("start", "finish"));
                        line = streamReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("Word 'start' is replaced with 'finish': ");
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
