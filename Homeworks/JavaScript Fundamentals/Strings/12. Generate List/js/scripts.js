/*
 Problem 12. Generate list
 Write a function that creates a HTML <ul> using a template for every HTML <li>.
 The source of the list should be an array of elements.
 Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 */

var result = document.getElementById('result');

var people = [{name: 'Peter', age: 14}, {name: 'Maria', age: 15}, {name: 'Gosho', age: 16}];
var tmpl = document.getElementById('list-item').innerHTML;
var peopleList = generateList(people, tmpl);

result.innerHTML = peopleList;
console.log(peopleList);

//peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'

function stringFormat(person, template) {
    template = template.replace('-{name}-', person.name);
    template = template.replace('-{age}-', person.age);

    return template;
}

function generateList(people, template) {
    var result = '<ul>';

    for (var i = 0; i < people.length; i++) {
        var person = people[i];
        result += '<li>' + stringFormat(person, template) + '</li>';
    }

    result += '</ul>';

    return result;
}


