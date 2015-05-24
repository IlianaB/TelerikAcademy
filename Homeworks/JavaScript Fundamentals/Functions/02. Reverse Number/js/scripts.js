/*
 Problem 2. Reverse number
 Write a function that reverses the digits of given decimal number
 */

var result = document.getElementById('result');

var number = 256;

console.log('The number ' + number + ' with reversed digits: ' + reverseNumber((number)));
result.innerHTML += 'The number ' + number + ' with reversed digits: ' + reverseNumber((number));

function reverseNumber(number) {
    var result = 0;

    while (number > 0) {
        result *= 10;
        result += number % 10;
        number = Math.floor(number / 10);
    }
    return result;
}
