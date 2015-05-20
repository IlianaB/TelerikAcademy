/*
 Problem 1. Exchange if greater
 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 */

var result = document.getElementById('result');

var a = 5,
    b = 2,
    c;

if(a > b) {
    c = a;
    a = b;
    b = c;
}

console.log('a = ' + a);
result.innerHTML += 'a = ' + a + ' b = ' + b;
console.log('b = ' + b);
