using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


class Program
{
    static void Main()
    {
        string input = " ";
        List<BigInteger> myList = new List<BigInteger>();
        BigInteger product = 1;
        BigInteger finalProduct = 1;

        do
        {
            input = Console.ReadLine();
            if (input != "END")
            {
                BigInteger number = BigInteger.Parse(input);
                myList.Add(number);
            }

        } while (input != "END");

        if (myList.Count > 10)
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 1 && myList[i] != 0)
                {
                    while (myList[i] > 0)
                    {
                        BigInteger digit = (myList[i] % 10);
                        if (digit != 0)
                        {
                            product *= digit;
                        }
                        myList[i] /= 10;
                    }
                }
                else if (i % 2 == 1 && myList[i] == 0)
                {
                    product = 1;
                }

                finalProduct *= product;
                product = 1;
            }

            Console.WriteLine(finalProduct);
            finalProduct = 1;

            for (int i = 10; i < myList.Count; i++)
            {

                if (i % 2 == 1 && myList[i] != 0)
                {
                    while (myList[i] > 0)
                    {
                        BigInteger digit = (myList[i] % 10);
                        if (digit != 0)
                        {
                            product *= digit;
                        }
                        myList[i] /= 10;
                    }
                }
                else if (i % 2 == 1 && myList[i] == 0)
                {
                    product = 1;
                }

                finalProduct *= product;
                product = 1;
            }

            Console.WriteLine(finalProduct);
            finalProduct = 1;
        }

        else if (myList.Count <= 10)
        {
            for (int i = 0; i < myList.Count; i++)
            {

                if (i % 2 == 1 && myList[i] != 0)
                {
                    while (myList[i] > 0)
                    {
                        BigInteger digit = (myList[i] % 10);

                        if (digit != 0)
                        {
                            product *= digit;
                        }
                        myList[i] /= 10;
                    }
                }
                else if (i % 2 == 1 && myList[i] == 0)
                {
                    product = 1;
                }

                finalProduct *= product;
                product = 1;
            }

            Console.WriteLine(finalProduct);
        }
    }
}

