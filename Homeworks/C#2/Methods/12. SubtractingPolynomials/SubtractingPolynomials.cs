using System;

//Extend the previous program to support also subtraction and multiplication of polynomials.

namespace _12.SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        static void Main()
        {
            decimal[] firstPolynomial = EnterPolynomial();
            Console.Write("Polynomial in normal form: ");
            PrintPolynomial(firstPolynomial);

            Console.WriteLine();

            decimal[] secondPolynomial = EnterPolynomial();
            Console.Write("Polynomial in normal form: ");
            PrintPolynomial(secondPolynomial);

            decimal[] result = AddPolynomial(firstPolynomial, secondPolynomial);

            Console.WriteLine("\n" + new string('-', 40) + "\n");
            PrintPolynomial(firstPolynomial);
            Console.WriteLine("   +");
            PrintPolynomial(secondPolynomial);
            Console.WriteLine("   =");
            PrintPolynomial(result);

            Console.WriteLine(new string('-', 40));
            result = Subtraction(firstPolynomial, secondPolynomial);

            Console.WriteLine("\n" + new string('-', 40) + "\n");
            PrintPolynomial(firstPolynomial);
            Console.WriteLine("   -");
            PrintPolynomial(secondPolynomial);
            Console.WriteLine("   =");
            PrintPolynomial(result);

            Console.WriteLine(new string('-', 40));
            result = Multiplication(firstPolynomial, secondPolynomial);

            Console.WriteLine("\n" + new string('-', 40) + "\n");
            PrintPolynomial(firstPolynomial);
            Console.WriteLine("  *");
            PrintPolynomial(secondPolynomial);
            Console.WriteLine("   =");
            PrintPolynomial(result);
        }

        static decimal[] EnterPolynomial()
        {
            Console.Write("Enter your polynomial degree: ");
            byte degree = byte.Parse(Console.ReadLine());

            decimal[] polynomial = new decimal[degree + 1];

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                polynomial[i] = decimal.Parse(Console.ReadLine());
            }

            return polynomial;
        }

        static decimal[] AddPolynomial(decimal[] first, decimal[] second)
        {
            int lengthBigger = Math.Max(first.Length, second.Length);
            bool isFirstBigger = first.Length >= second.Length;

            decimal[] result = new decimal[lengthBigger];

            for (int i = 0; i < lengthBigger; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    result[i] = first[i] + second[i];
                }
                else if (isFirstBigger)
                {
                    result[i] = first[i];
                }
                else
                {
                    result[i] = second[i];
                }
            }

            return result;
        }

        static decimal[] Subtraction(decimal[] first, decimal[] second)
        {
            int lengthBigger = Math.Max(first.Length, second.Length);
            bool isFirstBigger = first.Length >= second.Length;

            decimal[] result = new decimal[lengthBigger];

            for (int i = 0; i < lengthBigger; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    result[i] = first[i] - second[i];
                }
                else if (isFirstBigger)
                {
                    result[i] = first[i];
                }
                else
                {
                    result[i] = -second[i];
                }
            }

            return result;
        }

        static decimal[] Multiplication(decimal[] first, decimal[] second)
        {
            decimal[] result = new decimal[first.Length + second.Length - 1];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    result[i + j] += (first[i] * second[j]);
                }
            }

            return result;
        }

        static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (i == polynomial.Length - 1 && polynomial[i] != 0)
                {
                    Console.Write("{0}{1}x^{2} ", polynomial[i] > 0 ? "" : "-", Math.Abs(polynomial[i]), i);
                }
                else if (i == 0)
                {
                    if (polynomial[i] < 0) Console.Write("{0}{1} ", "- ", -polynomial[i]);
                    else if (polynomial[i] > 0) Console.Write("{0}{1} ", "+ ", polynomial[i]);
                }
                else
                {
                    if (polynomial[i] < 0) Console.Write("{0}{1}x^{2} ", "- ", -polynomial[i], i);
                    else if (polynomial[i] > 0) Console.Write("{0}{1}x^{2} ", "+ ", polynomial[i], i);
                }
            }
            Console.WriteLine();
        }
    }
}
