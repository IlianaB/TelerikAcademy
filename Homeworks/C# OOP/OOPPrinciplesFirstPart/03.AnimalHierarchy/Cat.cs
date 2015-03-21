namespace _03.AnimalHierarchy
{
    using System;

    abstract class Cat : Animal
    {
        //Constructor
        public Cat(int age, string name) :base(age, name)
        {
            this.Type = Type.Cat;
        }

        public override string MakeSound()
        {
           return string.Format("{0} {1} often says \"Mew!!!\"", this.Type, this.Name);
        }
    }
}
