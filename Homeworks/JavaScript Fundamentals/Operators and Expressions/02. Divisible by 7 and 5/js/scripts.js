/*
 Problem 2. Divisible by 7 and 5
 Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */

var result = document.getElementById('result');

var canBeDevided = 35;
var canNotBeDevided = 14;

console.log(checkIfDivisible(canBeDevided));
result.innerHTML += 'The number ' + canBeDevided + ' can be devided by 7 and 5 in the same time: ' + checkIfDivisible(canBeDevided) + '<br />';
console.log(checkIfDivisible(canNotBeDevided));
result.innerHTML += 'The number ' + canNotBeDevided + ' can be devided by 7 and 5 in the same time: ' + checkIfDivisible(canNotBeDevided) + '<br />';

function checkIfDivisible(number) {
    return !(number % 35);
}
