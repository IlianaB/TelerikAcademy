/*
 Problem 5. Third bit
 Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
 The bits are counted from right to left, starting from bit #0.
 The result of the expression should be either 1 or 0.
 */

var result = document.getElementById('result');

var withoutThirdBit0 = 5;
var withThirdBit0 = 15;

console.log(checkIfThirDBitIsZero(withoutThirdBit0));
result.innerHTML += 'The third bit of ' + withoutThirdBit0 + ' is: ' + checkIfThirDBitIsZero(withoutThirdBit0) + '<br />';
console.log(checkIfThirDBitIsZero(withThirdBit0));
result.innerHTML += 'The third bit of ' + withoutThirdBit0 + ' is: ' + checkIfThirDBitIsZero(withThirdBit0) + '<br />';

function checkIfThirDBitIsZero(number) {
    return (number >> 3) & 1;
}
