namespace FactoryMethod.Manufacturers
{
    using FactoryMethod.Products;

    internal class StormtrooperAcademy : HeroManufacturer
    {
        internal override Fighter ManufacturePerson(string stromtroopersName)
        {
            var stromtrooper = new Stormtrooper();
            stromtrooper.Name = stromtroopersName;
            stromtrooper.Armor = "Heavy armor";
            stromtrooper.Weapon = "Laser gun";
            return stromtrooper;
        }
    }
}
