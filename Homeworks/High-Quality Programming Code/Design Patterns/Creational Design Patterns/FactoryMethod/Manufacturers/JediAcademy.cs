namespace FactoryMethod.Manufacturers
{
    using FactoryMethod.Products;

    internal class JediAcademy : HeroManufacturer
    {
        internal override Fighter ManufacturePerson(string jedisName)
        {
            var jedi = new Jedi();
            jedi.Name = jedisName;
            jedi.Armor = "Danger intuition";
            jedi.Weapon = "Lightsaber";
            return jedi;
        }
    }
}
