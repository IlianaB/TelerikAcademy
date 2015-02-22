using System;
using System.Collections.Generic;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("Write a Math experssion: ");
            string expression = Console.ReadLine();

            Console.WriteLine(Check(expression) ? "Expression is valid" : "Expression is invalid");
        }

        private static bool Check(string expression)
        {
            Stack<char> leftBrackets = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBrackets.Push(expression[i]);
                }

                if (expression[i] == ')')
                {
                    if (leftBrackets.Count > 0)
                    {
                        leftBrackets.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

