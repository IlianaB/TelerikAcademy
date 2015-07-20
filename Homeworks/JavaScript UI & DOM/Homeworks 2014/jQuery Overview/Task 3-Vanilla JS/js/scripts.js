/*
 By given an array of students, generate a table that represents these students
 Each student has first name,last name and grade
 Use jQuery
 */

var students = [
        {
            'First name': 'Peter',
            'Last name': 'Ivanov',
            'Grade': 3
        }, {
            'First name': 'Milena',
            'Last name': 'Grigorova',
            'Grade': 6
        }, {
            'First name': 'Gergana',
            'Last name': 'Borisova',
            'Grade': 12
        }, {
            'First name': 'Boyko',
            'Last name': 'Petrov',
            'Grade': 7
        }
    ],
    currentStudent;

var table = document.createElement('table'),
    tHead = document.createElement('th'),
    tRow = document.createElement('tr'),
    tData = document.createElement('td'),
    dfg = document.createDocumentFragment(),
    currTHead,
    currTRow,
    currTData;

currentStudent = students[0];

for (var prop in currentStudent) {
    currTHead = tHead.cloneNode(true);
    currTHead.innerText = prop;
    dfg.appendChild(currTHead);
}

for (var i = 0; i < students.length; i++) {
    currentStudent = students[i];
    currTRow = tRow.cloneNode(true);

    for (var prop in currentStudent) {
        currTData = tData.cloneNode(true);
        currTData.innerText = currentStudent[prop];
        currTRow.appendChild(currTData);
    }

    dfg.appendChild(currTRow);
}

table.appendChild(dfg);
document.body.appendChild(table);