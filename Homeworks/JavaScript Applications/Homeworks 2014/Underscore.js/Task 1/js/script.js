/*
Task 1
 Write a method that from a given array of students finds all students
 whose first name is before its last name alphabetically.
 Print the students in descending order by full name.
 Use Underscore.js
 */

var filteredStudents = getStudentsWithFirstNameBeforeLastName(),
    sortedStudents = sortStudentsDescendingByFullName(filteredStudents),
    result = document.getElementById('result');

printStudentsCollection(sortedStudents);

function getStudentsWithFirstNameBeforeLastName() {
    var allStudents = _.filter(CONST.students, areWithFirstNameBeforeLastName);

    return allStudents;
}

function sortStudentsDescendingByFullName(collection) {
    var sortedStudents = _.sortBy(collection, sortByFullBName);

    return sortedStudents;
}

function printStudentsCollection(collection) {
    var text = '<ul>',
        currentStudent;

    for (var i = 0; i < collection.length; i++) {
        currentStudent = collection[i];

        text += '<li><strong>Student ' + (i + 1) + '</strong>' +
            '<p>' + '  - Name: ' + currentStudent.firstName + ' ' + currentStudent.lastName + '</p>' +
            '<p>' + '  - Age: ' + currentStudent.age + '</p>' +
            '</li>';
    }

    text += '</ul>'

    result.innerHTML += text;
    console.log(collection);
}

function areWithFirstNameBeforeLastName(student) {
    if (student.firstName < student.lastName) {
        return true;
    }
    return false;
}

function sortByFullBName(student) {
    var fullName = student.firstName + ' ' + student.lastName;

    return fullName;
}
