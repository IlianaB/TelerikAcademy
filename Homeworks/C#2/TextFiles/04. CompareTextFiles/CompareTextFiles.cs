using System;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

namespace _04.CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            using (StreamReader firstFile = new StreamReader(@"..\..\firstFile.txt"))
            {
                using (StreamReader secondFile = new StreamReader(@"..\..\secondFile.txt"))
                {
                    int sameLinesCount = 0;
                    int differentLinesCount = 0;
                    string firstLine = firstFile.ReadLine();
                    string secondLine = secondFile.ReadLine();

                    while (firstLine != null)
                    {
                        if (firstLine.Equals(secondLine))
                        {
                            sameLinesCount++;
                        }
                        else
                        {
                            differentLinesCount++;
                        }

                        firstLine = firstFile.ReadLine();
                        secondLine = secondFile.ReadLine();
                    }

                    Console.WriteLine("Same lines in the two files are: " + sameLinesCount);
                    Console.WriteLine("Different lines in the two files are: " + differentLinesCount);
                }
            }
        }
    }
}
