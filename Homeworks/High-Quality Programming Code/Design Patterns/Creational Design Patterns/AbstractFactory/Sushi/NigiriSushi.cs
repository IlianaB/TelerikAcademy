namespace AbstractFactory.Sushi
{
    using System.Collections.Generic;
    using System.Text;

    internal class NigiriSushi : Sushi
    {
        private const string name = "Nigiri";

        internal NigiriSushi(IEnumerable<string> ingredients, string madeBy)
            : base(ingredients, madeBy)
        {
        }

        internal string Name
        {
            get
            {
                return name;
            }
        }

        internal override string ToString()
        {
            StringBuilder sushiDetails = new StringBuilder();
            sushiDetails.AppendFormat("Sushi name: {0}", this.Name);
            sushiDetails.AppendLine();
            sushiDetails.Append(base.ToString());
            return sushiDetails.ToString();
        }
    }
}
