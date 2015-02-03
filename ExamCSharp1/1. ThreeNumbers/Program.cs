using System;
using System.Linq;
using System.Threading;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            decimal mean = 0m;

            long[] arr = { a, b, c };

            mean = (decimal)(((decimal)a + (decimal)b + (decimal)c) / 3);

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine("{0:F2}", mean);
        }
    }
}