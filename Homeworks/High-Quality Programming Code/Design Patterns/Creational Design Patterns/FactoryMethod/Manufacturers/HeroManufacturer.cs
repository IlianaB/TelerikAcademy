namespace FactoryMethod.Manufacturers
{
    using FactoryMethod.Products;

    internal abstract class HeroManufacturer
    {
        internal abstract Fighter ManufacturePerson(string name);
    }
}
