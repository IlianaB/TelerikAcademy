using System;
using System.Collections.Generic;
using System.Linq;
namespace AbstractFactory.Factories
{
    using System.Collections.Generic;
    using AbstractFactory.Sushi;

    internal class SunriseDelicious : SushiFactory
    {
        private const string Name = "Sunrise Delicious";

        internal override MakiSushi MakeMakiSushi()
        {
            var ingredients = new List<string> { "Rice", "Yuba", "Nori", "An awesome secret ingredient" };
            var makiSushi = new MakiSushi(ingredients, Name);
            return makiSushi;
        }

        internal override NigiriSushi MakeNigiriSushi()
        {
            var ingredients = new List<string> { "Rice", "Blue fish", "Nori", "Gukan" };
            var nigiriSushi = new NigiriSushi(ingredients, Name);
            return nigiriSushi;
        }
    }
}
