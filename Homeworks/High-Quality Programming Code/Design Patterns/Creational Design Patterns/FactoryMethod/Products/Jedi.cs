namespace FactoryMethod.Products
{
    using System;

    internal class Jedi : Fighter
    {
        public override void Fight()
        {
            Console.WriteLine("{0} on... bzzzzt... Action!", this.Weapon);
        }

    }
}
