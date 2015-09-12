namespace BuilderPattern
{
    using System.Text;

    internal class Meal
    {
        private readonly string mealType;

        internal Meal(string mealType)
        {
            this.mealType = mealType;
        }

        internal string Food { get; set; }

        internal string Desert { get; set; }

        internal string Beverage { get; set; }

        public override string ToString()
        {
            StringBuilder mealDetails = new StringBuilder();
            mealDetails.AppendFormat("Meal type: {0}", this.mealType);
            mealDetails.AppendLine();
            mealDetails.AppendFormat("Food: {0}", this.Food);
            mealDetails.AppendLine();
            mealDetails.AppendFormat("Desert: {0}", this.Desert);
            mealDetails.AppendLine();
            mealDetails.AppendFormat("Beverage: {0}", this.Beverage);
            return mealDetails.ToString();
        }

    }
}
