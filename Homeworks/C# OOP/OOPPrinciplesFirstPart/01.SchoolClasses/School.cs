namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        //Fields
        private string name;
        private List<Class> classes;

        //Constructors
        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }

        //Properties
        public string Name
        {
            get 
            { 
                return this.name; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The school's name cannot be null!");
                }
                this.name = value; 
            }
        }

        public List<Class> Classes
        {
            get 
            { 
                return new List<Class>(this.classes); 
            }
        }

        //Methods
        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }
    }
}
