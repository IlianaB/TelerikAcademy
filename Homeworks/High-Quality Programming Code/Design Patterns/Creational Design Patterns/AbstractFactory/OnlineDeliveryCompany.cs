namespace AbstractFactory
{
    using AbstractFactory.Factories;
    using AbstractFactory.Sushi;

    internal class OnlineDeliveryCompany
    {
        private readonly SushiFactory factory;

        internal OnlineDeliveryCompany(SushiFactory factory)
        {
            this.factory = factory;
        }

        internal MakiSushi DeliverMakiSushi()
        {
            return this.factory.MakeMakiSushi();
        }

        internal NigiriSushi DeliverNigiriSushi()
        {
            return this.factory.MakeNigiriSushi();
        }
    }
}
