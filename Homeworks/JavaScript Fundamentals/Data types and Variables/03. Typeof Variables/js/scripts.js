/*
 Problem 3. Typeof variables
 Try typeof on all variables you created.
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

var allVariables = [integerLiteral, floatLiteral, stringLiteral, boolLiteral, arrayLiteral, objectLiteral, functionLiteral];

for (var variable in allVariables) {
    console.log(typeof(allVariables[variable]));
    result.innerHTML += typeof (allVariables[variable]) + '<br />';
}