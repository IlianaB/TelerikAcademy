namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    class Student : Human
    {
        //Fields
        private int grade;

        //Constructors
        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }

        //Properties
        public int Grade
        {
            get 
            { 
                return this.grade; 
            }
            private set 
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grades are only between 1 and 12!");
                }

                this.grade = value; 
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} is in {1} grade", base.ToString(), this.Grade));

            return result.ToString();
        }

    }
}
