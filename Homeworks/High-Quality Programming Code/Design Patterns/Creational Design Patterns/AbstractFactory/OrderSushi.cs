namespace AbstractFactory
{
    using AbstractFactory.Factories;
    using System;

    class OrderSushi
    {
        static void Main(string[] args)
        {
            SushiFactory sushiRestorant = new HappyNinjas();
            var happyNinjasOrder = new OnlineDeliveryCompany(sushiRestorant);
            var makiSushi = happyNinjasOrder.DeliverMakiSushi();
            Console.WriteLine(makiSushi.ToString());
            Console.WriteLine(new string('-', 60));
            var nigiriSushi = happyNinjasOrder.DeliverNigiriSushi();
            Console.WriteLine(nigiriSushi.ToString());

            Console.WriteLine(new string('-', 60));

            sushiRestorant = new SunriseDelicious();
            var sunriseDeliciousOrder = new OnlineDeliveryCompany(sushiRestorant);
            makiSushi = sunriseDeliciousOrder.DeliverMakiSushi();
            Console.WriteLine(makiSushi.ToString());
            Console.WriteLine(new string('-', 60));
            nigiriSushi = sunriseDeliciousOrder.DeliverNigiriSushi();
            Console.WriteLine(nigiriSushi.ToString());
        }
    }
}
