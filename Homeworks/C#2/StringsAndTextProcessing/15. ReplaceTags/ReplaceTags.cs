using System;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

namespace _15.ReplaceТags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            input = input.Replace("<a href", "[URL");
            input = input.Replace("</a>", "[/URL]");
            int index = 0;
            int forDelete = 0;

            while (index != -1)
            {
                index = input.IndexOf("[URL", index);

                if (index != -1)
                {
                    forDelete = input.IndexOf(">", index);
                    input = input.Remove(forDelete, 1);
                    input = input.Insert(forDelete, "]");
                    index++;
                }
            }
            Console.WriteLine(input);
        }
    }
}
