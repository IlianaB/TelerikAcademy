namespace BuilderPattern.Directors
{
    using BuilderPattern.Builders;

    internal interface IMealConstructor
    {
        void Construct(MealBuilder mealBuilder);
    }
}
