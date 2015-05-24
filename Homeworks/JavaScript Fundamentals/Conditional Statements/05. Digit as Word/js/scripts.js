/*
 Problem 5. Digit as word
 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 */

var result = document.getElementById('result');

var a = 1,
    b = 5,
    c = 'hi';

console.log('a = ' + convertDigitInWord(a));
console.log('b = ' + convertDigitInWord(b));
console.log('c = ' + convertDigitInWord(c));
result.innerHTML += 'a = ' + convertDigitInWord(a) + '<br />' + 'b = ' + convertDigitInWord(b) + '<br />' + 'c = ' + convertDigitInWord(c);


function convertDigitInWord(digit) {
    var word;

    switch (digit) {
        case 0:
            word = 'Zero';
            break;
        case 1:
            word = 'One';
            break;
        case 2:
            word = 'Two';
            break;
        case 3:
            word = 'Three';
            break;
        case 4:
            word = 'Four';
            break;
        case 5:
            word = 'Five';
            break;
        case 6:
            word = 'Six';
            break;
        case 7:
            word = 'Seven';
            break;
        case 8:
            word = 'Eight';
            break;
        case 9:
            word = 'Nine';
            break;
        default:
            word = 'Not a digit';
            break;
    }

    return word;
}