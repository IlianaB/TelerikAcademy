var data = {
    title: 'My first template',
    student: {
        firstName: 'Iliana',
        lastName: 'Bobeva',
        age: 25,
        gender: 'female'
    },
    courses: [{
        name: 'C# 1',
        teachers: [{
            firstName: 'Pesho',
            lastName: 'Peshev',
            age: 32,
            isFemale: false
        }, {
            firstName: 'Pesho',
            lastName: 'Peshev',
            age: 22,
            isFemale: false
        }]
    }, {
        name: 'C# 2',
        teachers: [{
            firstName: 'Pesho 2',
            lastName: 'Peshev 2',
            age: 29,
            isFemale: false
        }, {
            firstName: 'Gosho 2',
            lastName: 'Goshov 2',
            age: 27,
            isFemale: false
        }]
    }]
};

Handlebars.registerHelper('fullName', function (person) {
    return person.firstName + ' ' + person.lastName;
});

Handlebars.registerHelper('genderType', function (gender) {
    if (gender === 'female') {
        return 'She';
    }

    return 'He';
});

var result = document.getElementById('result'),
    template = document.getElementById('template').innerHTML,
    postTemplate = Handlebars.compile(template);

result.innerHTML = postTemplate(data);