//Problem 1. School classes
//We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations,
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace _01.SchoolClasses
{
    using System;

    class Start
    {
        static void Main()
        {
            School school = new School("2AEG");

            Class firstClass = new Class('A');
            Class secondClass = new Class('B');
            Class thirdClass = new Class('C');

            Teacher firstTeacher = new Teacher("Pesho", "really cool!");
            Teacher secondTeacher = new Teacher("Gosho");

            Student firstStudent = new Student("Maria", "100000", "very hard-working");
            Student secondStudent = new Student("Penka", "100001", "not so hard-working");
            Student thirdStudent = new Student("Blagoi", "100002");
            Student forthStudent = new Student("Krasimir", "100003", "a bad boy");
            Student fifthStudent = new Student("Ivan", "100004");

            Discipline math = new Discipline("Maths", 5, 10, "everyone hates it!");
            Discipline history = new Discipline("History", 3, 6);
            Discipline geography = new Discipline("Geography", 3, 6);
            Discipline literature = new Discipline("Literature", 2, 4);

            school.AddClass(firstClass);
            school.AddClass(secondClass);
            school.AddClass(thirdClass);

            firstTeacher.AddDiscipline(math);
            firstTeacher.AddDiscipline(literature);
            secondTeacher.AddDiscipline(history);
            secondTeacher.AddDiscipline(geography);

            firstClass.AddStudentToAClass(firstStudent);
            firstClass.AddStudentToAClass(secondStudent);
            secondClass.AddStudentToAClass(thirdStudent);
            thirdClass.AddStudentToAClass(forthStudent);
            thirdClass.AddStudentToAClass(fifthStudent);

            firstClass.AddTeacherToAClass(firstTeacher);
            firstClass.AddTeacherToAClass(secondTeacher);
            secondClass.AddTeacherToAClass(firstTeacher);
            thirdClass.AddTeacherToAClass(secondTeacher);

            Console.WriteLine("School named {0} has {1} classes: \n\n {2} {3} {4}", school.Name, school.Classes.Count, firstClass, secondClass, thirdClass);
        }
    }
}
