namespace _03.AnimalHierarchy
{
    using System;

    class Dog : Animal
    {
        //Constructor
        public Dog(int age, string name, Gender gender) :base(age, name, gender)
        {
            this.Type = Type.Dog;
        }

        public override string MakeSound()
        {
            return string.Format("{0} {1} often says \"Bau!!!\"", this.Type, this.Name);
        }
    }
}
