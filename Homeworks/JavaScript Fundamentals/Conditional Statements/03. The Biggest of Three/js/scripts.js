/*
 Problem 3. The biggest of Three
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */

var result = document.getElementById('result');

var a = 5,
    b = 2,
    c = 2;

console.log('The biggest number between ' + a + ', ' + b + ' and ' + c + ' is: ' + findBiggest(a, b, c));
result.innerHTML += 'The biggest number between ' + a + ', ' + b + ' and ' + c + ' is: ' + findBiggest(a, b, c);

function findBiggest(a, b, c) {
    if (a >= b) {
        if (a >= c) {
            return a;
        }
        else {
            return c;
        }
    }
    else {
        if (b >= c) {
            return b;
        }
        else {
            return c;
        }
    }
}
