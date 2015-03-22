namespace _11.VersionAttribute
{
    using System;
    [Version("v. 2.11")]

    class Start
    {
        static void Main()
        {
            Type type = typeof(Start);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
