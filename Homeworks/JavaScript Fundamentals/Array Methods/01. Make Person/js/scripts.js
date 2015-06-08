/*
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

var result = document.getElementById('result'),
    firstNames = ['Pesho', 'Gosho', 'Stamat', 'Ivan', 'Blagoi', 'Dragan'],
    lastNames = ['Peshov', 'Goshov', 'Stamatov', 'Ivanov', 'Blagoev', 'Draganov'],
    ages = [20, 23, 30, 33, 35, 38],
    people = createPeople();

function createPeople() {
    var arr = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

    return arr.map(function () {
        return {
            firstName: generateFirstName(),
            lastName: generateLastName(),
            age: generateAge(),
            gender: generateGender()
        }
    });
}

function generateFirstName() {
    var index = Math.floor(Math.random() * firstNames.length);

    return firstNames[index];
}

function generateLastName() {
    var index = Math.floor(Math.random() * lastNames.length);

    return lastNames[index];
}

function generateAge() {
    var index = Math.floor(Math.random() * ages.length);

    return ages[index];
}

function generateGender() {
    return !!Math.round(Math.random());
}

function print() {
    result.innerHTML += 'Ten randomly generated people: <br />';
    console.log('Ten randomly generated people:');

    people.forEach(function (person) {
        result.innerHTML += person.firstName + ' ' + person.lastName + ' - male: ' + person.gender + ', ' + person.age + ' years old <br />';
        console.log(person.firstName + ' ' + person.lastName + ' - male: ' + person.gender + ', ' + person.age + ' years old');
    })
}

print();