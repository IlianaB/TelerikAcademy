/*
 Problem 4. Third digit
 Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 */

var result = document.getElementById('result');

var sevenNumber = 1789;
var notSevenNumber = 28;

console.log('The third digit of ' + sevenNumber + ' is 7: ' + checkThirdDigit(sevenNumber));
result.innerHTML += 'The third digit of ' + sevenNumber + ' is 7: ' + checkThirdDigit(sevenNumber) + '<br />';
console.log('The third digit of ' + notSevenNumber + ' is 7: ' + checkThirdDigit(notSevenNumber));
result.innerHTML += 'The third digit of ' + notSevenNumber + ' is 7: ' + checkThirdDigit(notSevenNumber) + '<br />';

function checkThirdDigit(number) {
    return (Math.floor(number / 100) % 10) === 7;
}
