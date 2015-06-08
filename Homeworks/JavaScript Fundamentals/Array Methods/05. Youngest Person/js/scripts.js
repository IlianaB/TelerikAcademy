/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */

var result = document.getElementById('result'),
    people = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 16, gender: 'male'},
        {firstName: 'Maria', lastName: 'Ivanova', age: 21, gender: 'female'},
        {firstName: 'Pesho', lastName: 'Goshov', age: 13, gender: 'male'},
        {firstName: 'Gergana', lastName: 'Georgieva', age: 30, gender: 'female'},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 21, gender: 'male'},
        {firstName: 'Krasimira', lastName: 'Marinova', age: 16, gender: 'female'},
        {firstName: 'Bay', lastName: 'Ivan', age: 17, gender: 'male'},
        {firstName: 'Petranka', lastName: 'Petrankova', age: 24, gender: 'female'},
        {firstName: 'Gosho', lastName: 'Petrov', age: 32, gender: 'male'},
        {firstName: 'Pesho', lastName: 'Goshov', age: 24, gender: 'male'},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 14, gender: 'male'},
        {firstName: 'Bay', lastName: 'Ivan', age: 81, gender: 'male'}
    ];

// MDN Array.prototype.find
if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}


function findYoungest(people) {
    var temp = people.sort(function (previous, current) {
        return previous.age - current.age
    });

    return temp.find(function (person) {
        return person.gender === 'male'
    });
}

var youngestPerson = findYoungest(people);

result.innerHTML += 'The youngest male person in the array is: ' + youngestPerson.firstName + ' ' + youngestPerson.lastName + ', age: ' + youngestPerson.age;
console.log('The youngest male person in the array is: ' + youngestPerson.firstName + ' ' + youngestPerson.lastName + ', age: ' + youngestPerson.age);