/*
 Problem 1. JavaScript literals
 Assign all the possible JavaScript literals to different variables.
 */

var result = document.getElementById('result');

var integerLiteral = 5;
var floatLiteral = 5.14;
var stringLiteral = 'Pesho';
var boolLiteral = true;
var arrayLiteral = ['Orange', 'Apple', 'Banana', 'Mango'];
var objectLiteral = {
    FirstName: 'Pesho',
    LastName: 'Peshev',
    Age: 25
};
var functionLiteral = function test() {
    return 5;
};

console.log('integer literal: ' + integerLiteral);
console.log('float literal: ' + floatLiteral);
console.log('string literal: ' + stringLiteral);
console.log('bool literal: ' + boolLiteral);
console.log('array literal: ' + arrayLiteral);
console.log('object literal:');
for (var property in objectLiteral) {
    console.log(property + ': ' + objectLiteral[property]);
}
console.log('function literal: ' + functionLiteral());

result.innerHTML += 'integer literal: ' + integerLiteral + '<br />';
result.innerHTML += 'float literal: ' + floatLiteral + '<br />';
result.innerHTML += 'string literal: ' + stringLiteral + '<br />';
result.innerHTML += 'bool literal: ' + boolLiteral + '<br />';
result.innerHTML += 'array literal: ' + arrayLiteral + '<br />';
result.innerHTML += 'object literal:' + '<br />';
for (var property in objectLiteral) {
    result.innerHTML += property + ': ' + objectLiteral[property] + '<br />';
}
result.innerHTML += 'function literal: ' + functionLiteral();


