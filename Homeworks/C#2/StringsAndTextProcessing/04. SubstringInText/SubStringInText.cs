using System;

//Write a program that finds how many times a sub-string is contained 
//in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. 
//We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

namespace _04.SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            string text = "The text is as follows: We are living in an yellow submarine." +
            "We don't have anything else. inside the submarine is very tight." +
            "So we are drinking all the day. We will move out of it in 5 days.";
            text = text.ToLower();
            int index = 0;
            int startIndex = 0;
            int count = 0;

            while (index != -1)
            {
                index = text.IndexOf("in", startIndex);
                startIndex = index + 1;

                if (index != -1)
                {
                    count++;
                }
            }

            Console.WriteLine("Substring \"in\" can be found {0} times in the text.", count);

        }
    }
}
