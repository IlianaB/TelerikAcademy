/*
 Problem 6.

 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */

var result = document.getElementById('result'),
    people = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 32},
        {firstName: 'Pesho', lastName: 'Goshov', age: 22},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 22},
        {firstName: 'Pesho', lastName: 'Ivanov', age: 81}
    ],
    groupByName = group(people, 'firstName'),
    groupByAge = group(people, 'age');

function group(arr, key) {
    var groups = {};

    arr.forEach(function (person) {
        var groupKey = person[key];

        if (!groups[groupKey]) {
            groups[groupKey] = [];
        }

        groups[groupKey].push(person);
    });

    return groups;
}

function print(obj, key) {
    console.log('Array grouped by: ' + key);

    for (var property in obj) {
        console.table(obj[property])
    }

    console.log('------------------------------------------')
}

print(groupByName, 'firstName');
print(groupByAge, 'age');

result.innerHTML += 'The result can be seen in the console. Press F12 to open it.';




