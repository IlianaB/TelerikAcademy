/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName` and `age` properties
 *   Array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve(){
    return function (students) {
        var sortedStudentsByAverageMark = _.sortBy(students, getAverageMark),
            studentWithHighestMark = _.first(sortedStudentsByAverageMark);

        print(studentWithHighestMark);

        function getAverageMark(student) {
            var marks = student.marks;

            var averageMark = _.reduce(marks, function(sum, mark) {
                return sum + mark;
            }, 0) / student.marks.length;

            student.averageMark = averageMark;

            return averageMark;
        }

        function getFullname(student) {
            var fullname = student.firstName + ' ' + student.lastName;

            return fullname;
        }

        function print(student) {
            console.log(getFullname(student) + ' has an average score of ' + student.averageMark);
        }
    };
}

module.exports = solve;