/*
 Problem 2. Multiplication Sign
 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */

var result = document.getElementById('result');

var a = 5,
    b = 2,
    c = 2;

console.log(showSign(a, b, c));
result.innerHTML += 'The sign of the product of ' + a + ', ' + b + ' and ' + c + ' is: ' + showSign(a, b,c);

function showSign(a, b, c) {
    var count = 0;

    if (a < 0) {
        count++;
    }

    if (b < 0) {
        count++;
    }

    if (c < 0) {
        count++;
    }

    if (count % 2 != 0)
    {
       return '-';
    }
    else {
        return '+';
    }

    if (a === 0 || b === 0 || c === 0)
    {
        return '0';
    }
}