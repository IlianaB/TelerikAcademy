/*
 Problem 1. Odd or Even
 Write an expression that checks if given integer is odd or even.
 */

var result = document.getElementById('result');

var oddNumber = 5;
var evenNumber = 6;

console.log(checkNumber(oddNumber));
result.innerHTML += 'The number ' + oddNumber + ' is: ' + checkNumber(oddNumber) + '<br />';
console.log(checkNumber(evenNumber));
result.innerHTML += 'The number ' + evenNumber + ' is: ' + checkNumber(evenNumber) + '<br />';

function checkNumber(number) {
    return number % 2 === 0 ? 'even' : 'odd';
}