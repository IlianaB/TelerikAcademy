using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

namespace _13.CountWords
{
    class CountWords
    {
        static void Main()
        {
            try
            {
                string[] words = File.ReadAllLines(@"../../words.txt");
                int[] count = new int[words.Length];

                using (StreamReader streamReader = new StreamReader(@"../../test.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            count[i] += ((Regex.Matches(line, @"\b" + words[i] + @"\b").Count));
                        }

                        line = streamReader.ReadLine();
                    }
                }

                Array.Sort(count, words);

                using (StreamWriter streamWriter = new StreamWriter(@"../../result.txt", false))
                {
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        streamWriter.WriteLine("{0}: {1}", words[i], count[i]);
                    }
                }

                Console.WriteLine("Words are counted and sorted: ");
                ReadFile(@"../../result.txt");
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
