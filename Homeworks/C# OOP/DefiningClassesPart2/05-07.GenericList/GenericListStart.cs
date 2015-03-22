namespace _05_07.GenericList
{
    using System;
    using System.Collections.Generic;

    class GenericListStart
    {
        static void Main()
        {
            //First test
            Console.WriteLine("-----First test with int starts here-----");
            Console.WriteLine();

            var test = new GenericList<int>(2);
            test.AddElement(4);
            test.AddElement(5);
            test.AddElement(6);

            Console.Write("The element at index 1 is: ");
            Console.WriteLine(test.AccessByIndex(1)); //returns the value - 5

            Console.Write("The index of the element with value 5 is: ");
            Console.WriteLine(test.FindElementByValue(5)); //returns the index - 1;

            test.InsertElement(1, 456); //Insert element at position with index 1
            Console.Write("After inserting 456 at index 1, the elements in the list are: ");
            Console.WriteLine(test); //Result must be: 4 456 5 6

            test.RemoveElement(1);
            Console.Write("After removing the element at index 1, the elements in the list are: ");
            Console.WriteLine(test); //Result must be 4 5 6

            Console.Write("Getting the element at index 0: ");
            Console.WriteLine(test[0]); //Result must be 4

            Console.Write("Min: ");
            Console.WriteLine(test.Min()); //4
            Console.Write("Max: ");
            Console.WriteLine(test.Max()); //6

            test.ClearList();
            Console.Write("After clearing the list: ");
            Console.WriteLine(test);


            //Second test
            Console.WriteLine();
            Console.WriteLine("-----Second test with strings starts here-----");
            Console.WriteLine();

            var secondTest = new GenericList<string>(2);
            secondTest.AddElement("alal");
            secondTest.AddElement("babab");
            secondTest.AddElement("nana");

            Console.Write("The element at index 1 is: ");
            Console.WriteLine(secondTest.AccessByIndex(1)); //returns the value - babab

            Console.Write("The index of the element with value alal is: ");
            Console.WriteLine(secondTest.FindElementByValue("alal")); //returns the index - 0;

            secondTest.InsertElement(1, "nov"); //Insert element at position with index 1
            Console.Write("After inserting 456 at index 1, the elements in the list are: ");
            Console.WriteLine(secondTest); //Result must be: alal nov babab nana

            secondTest.RemoveElement(1);
            Console.Write("After removing the element at index 1, the elements in the list are: ");
            Console.WriteLine(secondTest); //Result must be alal babab nana

            Console.Write("Getting the element at index 0: ");
            Console.WriteLine(secondTest[0]); //Result must be alal

            Console.Write("Min: ");
            Console.WriteLine(secondTest.Min()); //alal
            Console.Write("Max: ");
            Console.WriteLine(secondTest.Max()); //nana

            secondTest.ClearList();
            Console.Write("After clearing the list: ");
            Console.WriteLine(secondTest);
        }
    }
}
