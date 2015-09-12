namespace FactoryMethod
{
    using FactoryMethod.Manufacturers;
    using System;

    class StartWars
    {
        private static void CreateHero(HeroManufacturer hero, string herosName)
        {
            var person = hero.ManufacturePerson(herosName);
            Console.WriteLine(person.ToString());
            person.Fight();
        }

        static void Main(string[] args)
        {
            CreateHero(new JediAcademy(), "Anakin");
            Console.WriteLine(new string('-', 60));

            CreateHero(new StormtrooperAcademy(), "Jack");
            Console.WriteLine(new string('-', 60));
        }
    }
}
