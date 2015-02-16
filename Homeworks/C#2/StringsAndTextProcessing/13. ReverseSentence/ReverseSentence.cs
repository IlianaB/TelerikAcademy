using System;

//Write a program that reverses the words in given sentence.

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            Console.Write("Write a sentence: ");
            string input = Console.ReadLine();
            //string input = "C# is not C++, not PHP and not Delphi!";

            string[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(array);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
