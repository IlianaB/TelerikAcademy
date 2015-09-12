namespace FactoryMethod.Products
{
    using System;

    internal class Stormtrooper : Fighter
    {
        public override void Fight()
        {
            Console.WriteLine("{0} on... Action! (pew) (pew) ... (pew)", this.Weapon);
        }

    }
}
