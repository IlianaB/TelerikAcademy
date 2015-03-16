using System;

namespace DefiningClasses
{
    class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM mobilePhone = new GSM("Xperia Z2", "Sony");
            mobilePhone.AddCalls(new Call(DateTime.Now, "+359888888888", 150));
            mobilePhone.AddCalls(new Call(DateTime.Now, "+359888668888", 250));
            mobilePhone.AddCalls(new Call(DateTime.Now, "+359888888844", 30));

            DisplayCallsInformation(mobilePhone);
            PrintTotalPrice(mobilePhone);
            RemoveLongestCall(mobilePhone);
            ClearAndPrintCallHistory(mobilePhone);
        }

        private static void ClearAndPrintCallHistory(GSM gsm)
        {
            gsm.ClearCallHistory();
            Console.WriteLine("After clearing the Call history: ");
            DisplayCallsInformation(gsm);
        }

        private static void RemoveLongestCall(GSM gsm)
        {
            int index = 0;
            int longest = 0;

            for (int i = 0; i < gsm.Calls.Count; i++)
            {
                if (gsm.Calls[i].Duration > longest)
                {
                    longest = gsm.Calls[i].Duration;
                    index = i;
                }
            }

            gsm.DeleteCalls(index);

            Console.Write("After removing the longest call - ");
            PrintTotalPrice(gsm);
        }

        private static void PrintTotalPrice(GSM gsm)
        {
            Console.WriteLine("Total price of calls: {0} BGN", gsm.CalculateTotalPrice());
            Console.WriteLine();
        }

        private static void DisplayCallsInformation(GSM gsm)
        {
            if (gsm.Calls.Count <= 0)
            {
                Console.WriteLine("There is no calls in the history!");
            }
            else
            {
                Console.WriteLine("Call History Information:");

                foreach (Call call in gsm.Calls)
                {
                    Console.WriteLine("Date: {0}", call.Date);
                    Console.WriteLine("Number: {0}", call.Number);
                    Console.WriteLine("Duration in seconds: {0}", call.Duration);
                }
            }

            Console.WriteLine();
        }
    }
}
