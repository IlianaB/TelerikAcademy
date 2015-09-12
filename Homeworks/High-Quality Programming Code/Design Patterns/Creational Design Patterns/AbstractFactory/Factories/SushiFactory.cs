namespace AbstractFactory.Factories
{
    using AbstractFactory.Sushi;

    internal abstract class SushiFactory
    {
        internal abstract MakiSushi MakeMakiSushi();

        internal abstract NigiriSushi MakeNigiriSushi();
    }
}
