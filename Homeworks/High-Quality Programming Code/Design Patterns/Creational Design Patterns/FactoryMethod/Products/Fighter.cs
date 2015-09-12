namespace FactoryMethod.Products
{
    using System.Text;

    internal abstract class Fighter
    {
        public string Name { get; set; }

        public string Armor { get; set; }

        public string Weapon { get; set; }

        public abstract void Fight();

        public override string ToString()
        {
            StringBuilder personData = new StringBuilder();
            personData.AppendFormat("My name is: {0}", this.Name);
            personData.AppendLine();
            personData.AppendFormat("I'm protecting my self with: {0}", this.Armor);
            personData.AppendLine();
            personData.AppendFormat("I'm attacing wth: {0}", this.Weapon);
            personData.AppendLine();
            return personData.ToString();
        }

    }
}
