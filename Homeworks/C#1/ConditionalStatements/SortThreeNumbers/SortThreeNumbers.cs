using System;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

namespace SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double c = Double.Parse(Console.ReadLine());
            double first = 0;
            double second = 0;
            double third = 0;

            if (a >= b)
            {
                if (a >= c)
                {
                    first = a;

                    if (b >= c)
                    {
                        second = b;
                        third = c;
                    }
                    else
                    {
                        second = c;
                        third = b;
                    }
                }
                else
                {
                    first = c;
                    second = a;
                    third = b;
                }                
            } 
   
            else
            {
                if (b >= c)
                {
                    first = b;

                    if (a >= c)
                    {
                        second = a;
                        third = c;
                    }
                    else
                    {
                        second = c;
                        third = a;
                    }
                }
                else
                {
                    first = c;
                    second = b;
                    third = a;
                }            
            }

            Console.WriteLine(first + " " + second + " " + third);
        }
    }
}
