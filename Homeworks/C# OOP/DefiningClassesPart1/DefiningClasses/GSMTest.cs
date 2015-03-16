using System;

namespace DefiningClasses
{
    class GSMTest
    {
        public static void Test()
        {
            GSM mobilePhone1 = new GSM("Galaxy S5", "Samsung");
            GSM mobilePhone2 = new GSM("Lumia 513", "Nokia", 650);
            GSM mobilePhone3 = new GSM("Xperia Z3", "Sony", 1200, "Gosho",
                new Battery("Removable", 650, 20, BatteryType.LiIonPolymer),
                new Display(5.4, 16000000));

            GSM[] phones = { mobilePhone1, mobilePhone2, mobilePhone3 };

            DisplayInformation(phones);
        }

        private static void DisplayInformation(GSM[] phones)
        {
            foreach (GSM mobilePhone in phones)
            {
                Console.WriteLine(mobilePhone);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
