/*
 Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */

var result = document.getElementById('result'),
    peopleOlder = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 32},
        {firstName: 'Pesho', lastName: 'Goshov', age: 22},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 21},
        {firstName: 'Bay', lastName: 'Ivan', age: 81}
    ],
    peopleYounger = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 32},
        {firstName: 'Pesho', lastName: 'Goshov', age: 12},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 21},
        {firstName: 'Bay', lastName: 'Ivan', age: 81}
    ];

function checkAge(people) {
    return people.every(function (person) {
        return person.age >= 18;
    })
}

result.innerHTML += 'The array peopleOlder contains only people of age 18 or greater: ' + checkAge(peopleOlder) + '<br />';
result.innerHTML += 'The array peopleYounger contains only people of age 18 or greater: ' + checkAge(peopleYounger);

console.log('The array peopleOlder contains only people of age 18 or greater: ' + checkAge(peopleOlder));
console.log('The array peopleYounger contains only people of age 18 or greater: ' + checkAge(peopleYounger));