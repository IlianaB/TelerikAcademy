/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
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
    ],
    females = filterFemale(people),
    averageAge;

function filterFemale(people) {
    return people.filter(function (person) {
        return person.gender === 'female';
    })
}

function averageAge(females) {
    var total = females.reduce(function (previous, current) {
        var previousAge = previous.age ? previous.age : previous;

        return previousAge + current.age;
    });

    return total / females.length;
}

function print() {
    result.innerHTML += 'Average age of females: ' + averageAge(females) + ' years';
    console.log('Average age of females: ' + averageAge(females) + ' years');
}

print();
