/*
 Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.

 Example:

 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */

var result = document.getElementById('result'),
    people = [
        { firstName: 'Gosho', lastName: 'Petrov', age: 32 },
        { firstName: 'Pesho', lastName: 'Goshov', age: 22 },
        { firstName: 'Stamat', lastName: 'Stamatov', age: 21 },
        { firstName: 'Bay', lastName: 'Ivan', age: 81 }
    ];

function findYoungest(people) {
    var temp = { age: Number.MAX_VALUE }

    people.forEach(function (obj) {
        if (temp.age > obj.age) {
            temp = obj;
        }
    });

    return temp;
}

var youngestPerson = findYoungest(people);

result.innerHTML += 'The youngest person in the array is: ' + youngestPerson.firstName + ' ' + youngestPerson.lastName + ', age: ' + youngestPerson.age;
console.log('The youngest person in the array is: ' + youngestPerson.firstName + ' ' + youngestPerson.lastName + ', age: ' + youngestPerson.age);



