/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName`, `lastName` and `age` properties
 *   **finds** the students whose age is between 18 and 24
 *   **prints**  the fullname of found students, sorted lexicographically ascending
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        var youngStudents = _.filter(students, checkIfAgeBetween18And24),
            studentsSortedLexicographically = _.sortBy(youngStudents, getFullname);

        print(studentsSortedLexicographically);

        function checkIfAgeBetween18And24(student) {
            return student.age >= 18 && student.age <= 24;
        }

        function getFullname(student) {
            var fullname = student.firstName + ' ' + student.lastName;

            return fullname;
        }

        function print(students) {
            _.each(students, function (student) {
                console.log(getFullname(student));
            });
        }
    };
}

module.exports = solve;