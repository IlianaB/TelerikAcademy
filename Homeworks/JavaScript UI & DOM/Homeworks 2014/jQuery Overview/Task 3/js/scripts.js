/*
 By given an array of students, generate a table that represents these students
 Each student has first name,last name and grade
 Use jQuery
 */

var students = [
        {
            firstName: 'Peter',
            lastName: 'Ivanov',
            grade: 3
        }, {
            firstName: 'Milena',
            lastName: 'Grigorova',
            grade: 6
        }, {
            firstName: 'Gergana',
            lastName: 'Borisova',
            grade: 12
        }, {
            firstName: 'Boyko',
            lastName: 'Petrov',
            grade: 7
        }
    ],
    currentStudent,
    content;

$('body').append('<table></table>');
$('table').append('<th>First name</th><th>Last name</th><th>Grade</th>');

for (var i = 0; i < students.length; i++) {
    currentStudent = students[i];

    $('table').append('<tr></tr>');

    for (var prop in currentStudent) {
        content = '<td>' + currentStudent[prop] + '</td>';
        $('tr:last-child').append(content);
    }
}