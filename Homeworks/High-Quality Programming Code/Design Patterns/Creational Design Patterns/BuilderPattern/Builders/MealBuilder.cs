namespace BuilderPattern.Builders
{
    internal abstract class MealBuilder
    {
        internal Meal Meal { get; set; }

        internal abstract void GetFood();

        internal abstract void GetDesert();

        internal abstract void GetBeverage();
    }
}
