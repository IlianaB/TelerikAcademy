using System;
using System.Text;

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

namespace _01.StringsInCSharp
{
    class StringsInCSharp
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', Console.WindowWidth - 2));
            sb.AppendLine("A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a string, use the StringInfo object.");
            sb.AppendLine(new string('-', Console.WindowWidth - 2));
            sb.AppendLine("Important C# string methods:");
            sb.AppendLine("string.IndexOf(): Reports the zero-based index of the first occurrence of the specified Unicode character in this string.");
            sb.AppendLine("string.Compare(): Compares two specified String objects and returns an integer that indicates their relative position in the sort order.");
            sb.AppendLine("string.Clone(): Returns a reference to this instance of String.");
            sb.AppendLine("string.Equals(): Determines whether this instance and a specified object, which must also be a String object, have the same value.");
            sb.AppendLine("string.Join(): Concatenates the elements of an object array, using the specified separator between each element.");
            sb.AppendLine("string.Substring(): Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.");
            sb.AppendLine("string.Split(): Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.");
            sb.AppendLine(new string('-', Console.WindowWidth - 2));

            Console.WriteLine(sb.ToString());
        }
    }
}
