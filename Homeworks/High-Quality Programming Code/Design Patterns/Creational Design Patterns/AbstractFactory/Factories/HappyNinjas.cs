namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory.Sushi;

    internal class HappyNinjas : SushiFactory
    {
        private const string Name = "Happy Ninjas";

        internal override MakiSushi MakeMakiSushi()
        {
            var ingredients = new List<string> { "rice", "Yuba", "Nori", "Tamago" };
            var makiSushi = new MakiSushi(ingredients, Name);
            return makiSushi;
        }

        internal override NigiriSushi MakeNigiriSushi()
        {

            var ingredients = new List<string> { "Rice", "Red fish", "Wassaby" };
            var nigiriSushi = new NigiriSushi(ingredients, Name);
            return nigiriSushi;
        }
    }
}
