namespace BuilderPattern
{
    using BuilderPattern.Builders;
    using BuilderPattern.Directors;
    using System;

    class HungerGames
    {
        static void Main(string[] args)
        {
            IMealConstructor mealConstructor = new MealConstructor();

            Console.WriteLine("----Monday---- \n");
            MealBuilder buildBreakfast = new BreakfastBuilder("Eggs & bacon", "Apple", "Coffe");
            mealConstructor.Construct(buildBreakfast);
            Console.WriteLine(buildBreakfast.Meal.ToString());

            Console.WriteLine("-------------------");

            MealBuilder buildLunch = new LunchBuilder("Fish and chips", "Ice cream", "Pepsi");
            mealConstructor.Construct(buildLunch);
            Console.WriteLine(buildLunch.Meal.ToString());

            Console.WriteLine("-------------------");

            MealBuilder buildDinner = new DinnerBuilder("Pasta", "Pop-corn", "Beer");
            mealConstructor.Construct(buildDinner);
            Console.WriteLine(buildDinner.Meal.ToString());

            Console.WriteLine("\n----Wednesday----\n");
            buildBreakfast = new BreakfastBuilder("Pancakes", "Orage", "Coffe");
            mealConstructor.Construct(buildBreakfast);
            Console.WriteLine(buildBreakfast.Meal.ToString());

            Console.WriteLine("-------------------");


            buildLunch = new LunchBuilder("Hamburger", "Bounty", "Coca cola");
            mealConstructor.Construct(buildLunch);
            Console.WriteLine(buildLunch.Meal.ToString());

            Console.WriteLine("-------------------");


            buildDinner = new DinnerBuilder("Musaka", "Pop-corn", "7up");
            mealConstructor.Construct(buildDinner);
            Console.WriteLine(buildDinner.Meal.ToString());

        }
    }
}
