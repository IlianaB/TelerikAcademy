using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            char dot = '.';
            char space = ' ';
            char left = '\\';
            char right = '/';
            char ex = 'X';
            char hash = '#';

            for (int i = 0; i < n; i++)
            {
                int inner = width - (2 * i) - 2;

                Console.Write(new string(hash, i));
                Console.Write(left);

                if (inner - 2 * d < 3)
                {
                    Console.Write(new string(space, width - 2 - (2 * i)));
                }


                if (inner - 2 * d >= 3)
                {
                    Console.Write(new string(space, d));
                    Console.Write(left);
                    Console.Write(new string(dot, inner - 2 - 2 * d));
                    Console.Write(right);
                    Console.Write(new string(space, d));
                }

                Console.Write(right);
                Console.WriteLine(new string(hash, i));
            }

            //middle

            Console.Write(new string(hash, n));
            Console.Write(ex);
            Console.WriteLine(new string(hash, n));

            //down part

            for (int i = n - 1; i >= 0; i--)
            {
                int inner = width - (2 * i) - 2;

                Console.Write(new string(hash, i));
                Console.Write(right);

                if (inner - 2 * d < 3)
                {
                    Console.Write(new string(space, width - 2 - (2 * i)));
                }


                if (inner - 2 * d >= 3)
                {
                    Console.Write(new string(space, d));
                    Console.Write(right);
                    Console.Write(new string(dot, inner - 2 - 2 * d));
                    Console.Write(left);
                    Console.Write(new string(space, d));
                }

                Console.Write(left);
                Console.WriteLine(new string(hash, i));
            }
        }
    }
}
