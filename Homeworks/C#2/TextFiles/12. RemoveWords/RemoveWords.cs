using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

namespace _12.RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                string listedWords = @"\b" + String.Join("|", File.ReadAllLines(@"../../bannedWords.txt")) + @"\b";

                using (StreamReader streamReader = new StreamReader(@"../../input.txt"))
                {
                    using (StreamWriter streamWriter = new StreamWriter(@"../../output.txt", false))
                    {
                        string line = streamReader.ReadLine();

                        while (line != null)
                        {

                            streamWriter.WriteLine(Regex.Replace(line, listedWords, String.Empty));

                            line = streamReader.ReadLine();
                        }
                    }
                }

                Console.WriteLine("Words from the file are removed: ");
                ReadFile(@"../../output.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
