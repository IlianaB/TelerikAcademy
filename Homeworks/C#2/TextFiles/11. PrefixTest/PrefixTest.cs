using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

namespace _11.PrefixTest
{
    class PrefixTest
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
                        streamWriter.WriteLine(Regex.Replace(line, @"\btest\w* \b", String.Empty));
                        line = streamReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("All words with prefix 'test' are deleted: ");
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
