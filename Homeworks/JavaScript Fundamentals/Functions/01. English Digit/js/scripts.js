/*
 Problem 1. English digit
 Write a function that returns the last digit of given integer as an English word.
 */

var result = document.getElementById('result');

var number = 17;

console.log('The last digit of ' + number + ' is: ' + lastDigitAsWord((number)));
result.innerHTML += 'The last digit of ' + number + ' is: ' + lastDigitAsWord((number));

function lastDigitAsWord(number) {
    var lastDigit = 17 % 10,
        result;

    switch (lastDigit) {
        case 0: result = 'zero';
            break;
        case 1: result = 'one';
            break;
        case 2: result = 'two';
            break;
        case 3: result = 'three';
            break;
        case 4: result = 'four';
            break;
        case 5: result = 'five';
            break;
        case 6: result = 'six';
            break;
        case 7: result = 'seven';
            break;
        case 8: result = 'eight';
            break;
        case 9: result = 'nine';
            break;
    }

    return result;
}

