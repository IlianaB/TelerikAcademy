namespace BuilderPattern.Builders
{
    internal class LunchBuilder : MealBuilder
    {
        private string food;
        private string desert;
        private string beverage;

        internal LunchBuilder(string food, string desert, string beverage)
        {
            this.Meal = new Meal("Lunch");
            this.food = food;
            this.desert = desert;
            this.beverage = beverage;
        }

        internal override void GetBeverage()
        {
            this.Meal.Beverage = this.beverage;
        }

        internal override void GetDesert()
        {
            this.Meal.Desert = this.desert;
        }

        internal override void GetFood()
        {
            this.Meal.Food = this.food;
        }
    }
}
