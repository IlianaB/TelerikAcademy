/*
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

var result = document.getElementById('result'),
    people = [
        {firstName: 'Gosho', lastName: 'Petrov', age: 16},
        {firstName: 'Pesho', lastName: 'Goshov', age: 13},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 21},
        {firstName: 'Bay', lastName: 'Ivan', age: 17},
        {firstName: 'Gosho', lastName: 'Petrov', age: 32},
        {firstName: 'Pesho', lastName: 'Goshov', age: 24},
        {firstName: 'Stamat', lastName: 'Stamatov', age: 14},
        {firstName: 'Bay', lastName: 'Ivan', age: 81}
    ],
    underaged = getUnderaged(people);

function getUnderaged(people) {
    return people.filter(function (person) {
        return person.age < 18;
    })
}

function print() {
    result.innerHTML += 'All underaged people in the array: <br />';
    console.log('All underaged people in the array:');

    underaged.forEach(function (person) {
        result.innerHTML += person.firstName + ' ' + person.lastName + ' - ' + person.age + ' years old <br />';
        console.log(person.firstName + ' ' + person.lastName + ' - ' + person.age + ' years old');
    });
}

print();
