namespace AbstractFactory.Sushi
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal abstract class Sushi
    {
        private readonly IReadOnlyCollection<string> ingredients;
        private readonly string madeBy;

        protected Sushi(IEnumerable<string> ingredients, string madeBy)
        {
            this.ingredients = new List<string>(ingredients);
            this.madeBy = madeBy;
        }

        internal virtual string ToString()
        {
            StringBuilder sushiDetails = new StringBuilder();
            sushiDetails.AppendFormat("Made by: {0}", this.madeBy);
            sushiDetails.AppendLine();
            sushiDetails.AppendFormat("Ingredients: {0}", String.Join(", ", this.ingredients));
            return sushiDetails.ToString();
        }
    }
}
