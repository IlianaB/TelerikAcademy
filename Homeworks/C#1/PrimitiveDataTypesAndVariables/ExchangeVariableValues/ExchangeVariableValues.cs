using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 0;

            Console.WriteLine("Before the exchange the value of a is {0} and the value of b is {1}", a, b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After the exchange the value of a is {0} and the value of b is {1}", a, b);
        }
    }
}
