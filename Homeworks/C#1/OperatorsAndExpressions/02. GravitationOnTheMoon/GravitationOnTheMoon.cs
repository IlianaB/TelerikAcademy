using System;
using System.Threading;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Write your weight: ");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Your weight on the Moon is: " + (weight * 0.17d) + "kg");
        }
    }
}
