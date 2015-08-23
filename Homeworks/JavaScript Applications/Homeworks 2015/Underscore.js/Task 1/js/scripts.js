/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName` and `lastName` properties
 *   **Finds** all students whose `firstName` is before their `lastName` alphabetically
 *   Then **sorts** them in descending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   Then **prints** the fullname of founded students to the console
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        var studentsWithFirstNameBeforeLastName = _.filter(students, checkIfFirstNameIsBeforeLastName),
            sortedStudents = sortStudentsDescendingByFullName(studentsWithFirstNameBeforeLastName);

        print(sortedStudents);


        function checkIfFirstNameIsBeforeLastName(student) {
            return student.firstName < student.lastName;
        }

        function sortStudentsDescendingByFullName(students) {
            var result = _.sortBy(students, getFullName).reverse();

            return result;
        }

        function getFullName(student) {
            var fullName = student.firstName + ' ' + student.lastName;

            return fullName;
        }

        function print(students) {
            _.each(students, function (student) {
                console.log(getFullName(student));
            })
        }
    };
}

module.exports = solve;