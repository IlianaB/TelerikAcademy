//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
//Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            Dog[] dogsArray = {
                                  new Dog(12, "Pesho", Gender.Male),
                                  new Dog(2, "Gosho", Gender.Male),
                                  new Dog(6, "Mimi", Gender.Female),
                                  new Dog(8, "Liza", Gender.Female)
                              };

            Cat[] catsArray = {
                                  new Kitten(2, "Sara"),
                                  new Kitten(4, "Kara"),
                                  new Tomcat(3, "Sam"),
                                  new Tomcat(6, "Tom")
                              };

            Frog[] frogsArray = {
                                    new Frog(1, "Peshko", Gender.Male),
                                    new Frog(2, "Goshko", Gender.Male),
                                    new Frog(3, "Mimka", Gender.Female)
                                };

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.AddRange(dogsArray);
            allAnimals.AddRange(catsArray);
            allAnimals.AddRange(frogsArray);

            Console.WriteLine("Average age of dogs in the array is: {0} years.", CalculateAverageYears(dogsArray));
            Console.WriteLine("Average age of cats in the array is: {0} years.", CalculateAverageYears(catsArray));
            Console.WriteLine("Average age of frogs in the array is: {0} years.", CalculateAverageYears(frogsArray));

            Console.WriteLine();
            Console.WriteLine("----------Animals in the arrays----------");
            Console.WriteLine();

            foreach (var item in allAnimals)
            {
                Console.WriteLine(item.MakeSound());
            }
        }

        private static double CalculateAverageYears(Animal[] collection)
        {
            double averageAge = collection.Average(x => x.Age);

            return Math.Round(averageAge, 2);
        }
    }
}
