/*
 Problem 6.

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */

var result = document.getElementById('result'),
    people = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 32},
        {firstName: 'Pesho', lastName: 'Goshov', age: 22},
        {firstName: 'Pepi', lastName: 'Stamatov', age: 22},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 22},
        {firstName: 'Pesho', lastName: 'Ivanov', age: 81}
    ],
    groupByFirstLetter = group(people, true),
    groupByFirstName = group(people, false);

function group(people, groupByFirstLetter) {
    var groups = people.reduce(function (group, person) {
        var key = groupByFirstLetter ? person.firstName[0] : person.firstName;

        if (!group[key]) {
            group[key] = [];
        }

        group[key].push(person);

        return group;
    }, {});

    return groups;
}

function print(groups, key) {
    console.log('Array grouped by: ' + key);

    for (var groupName in groups) {
        console.log('Group name: ' + groupName);

        groups[groupName].forEach(function (person) {
            console.log('\t' + person.firstName + ' ' + person.lastName + ' ' + person.age);
        });
    }

    console.log('------------------------------------------')
}

print(groupByFirstLetter, 'first letter');
print(groupByFirstName, 'firstName');

result.innerHTML += 'The result can be seen in the console. Press F12 to open it.';