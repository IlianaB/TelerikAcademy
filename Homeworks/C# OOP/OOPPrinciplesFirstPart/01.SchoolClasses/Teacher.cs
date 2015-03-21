namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        //Fields
        private List<Discipline> disciplines;
        private string comment;

        //Constructors
        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }

        //Properties
        public List<Discipline> Disciplines
        {
            get 
            {
                return new List<Discipline>(this.disciplines);
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                this.comment = value;
            }
        }

        //Methods
        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }
    }
}
