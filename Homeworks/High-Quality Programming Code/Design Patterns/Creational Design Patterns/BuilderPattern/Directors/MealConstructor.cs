namespace BuilderPattern.Directors
{
    using BuilderPattern.Builders;

    internal class MealConstructor : IMealConstructor
    {
        public void Construct(MealBuilder mealBuilder)
        {
            mealBuilder.GetFood();
            mealBuilder.GetDesert();
            mealBuilder.GetBeverage();
        }
    }
}
