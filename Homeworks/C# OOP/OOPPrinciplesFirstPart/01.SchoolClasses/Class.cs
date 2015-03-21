namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : ICommentable
    {
        //Fields
        private char identifier;
        private List<Student> students;
        private List<Teacher> teachers;
        private string comment;

        //Constructors
        public Class(char identifier)
        {
            this.Identifier = identifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public Class(char identifier, string comment) : this(identifier)
        {
            this.Comment = comment;
        }

        //Properties
        public char Identifier
        {
            get 
            { 
                return this.identifier; 
            }
            private set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Class identifier should be a letter between A and Z!");
                }
                if (char.IsLower(value))
                {
                    throw new ArgumentException("Class identifier should be a capital letter!");
                }

                this.identifier = value;
            }
        }

        public List<Student> Students
        {
            get 
            { 
                return new List<Student>(this.students); 
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
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
        public void AddStudentToAClass(Student student)
        {
            this.students.Add(student);
        }

        public void AddTeacherToAClass(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Class \"{0}\" has {1} teachers: ", this.Identifier, this.Teachers.Count));

            for (int i = 0; i < this.teachers.Count; i++)
			{
                result.AppendLine(string.Format("* {0}, who have lectures on: ", this.teachers[i].Name));

                for (int j = 0; j < this.teachers[i].Disciplines.Count; j++)
                {
                    result.Append(string.Format("- {0}", this.teachers[i].Disciplines[j].Name));

                    if (this.teachers[i].Disciplines[j].Comment != null)
                    {
                        result.AppendLine(string.Format(" ({0})", this.teachers[i].Disciplines[j].Comment));
                    }
                    else
                    {
                        result.AppendLine();
                    }
                }
			}

            result.AppendLine(string.Format("And {0} students: ", this.students.Count));

            for (int i = 0; i < this.students.Count; i++)
            {
                result.AppendLine(string.Format("* {0} with class number: {1}", this.students[i].Name, this.students[i].ClassNumber));

                if (this.students[i].Comment != null)
                {
                    result.AppendLine(string.Format("You can expect from {0} to be {1}.", this.students[i].Name, this.students[i].Comment));
                }
            }

            result.AppendLine();

            return result.ToString();
        }
    }
}
