using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//Modify the solution of the previous problem to replace only whole words (not strings).

namespace _08.ReplaceWholeWord
{
    class ReplaceWholeWord
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
                        streamWriter.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
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