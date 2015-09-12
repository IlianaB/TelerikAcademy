namespace AbstractFactory.Sushi
{
    using System.Collections.Generic;
    using System.Text;

    internal class MakiSushi : Sushi
    {
        private const string name = "Maki";

        internal MakiSushi(IEnumerable<string> ingredients, string madeBy) 
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
