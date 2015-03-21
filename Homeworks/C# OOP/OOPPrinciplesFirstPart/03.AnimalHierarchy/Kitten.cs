namespace _03.AnimalHierarchy
{
    class Kitten : Cat
    {
        //Constructor
        public Kitten(int age, string name) :base(age, name)
        {
            Gender Gender = Gender.Female;
        }
    }
}
