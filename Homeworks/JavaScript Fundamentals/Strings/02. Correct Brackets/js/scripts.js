/*
 Problem 2. Correct brackets
 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

var result = document.getElementById('result');

var correctExp = '((a+b)/5-d)',
    incorrectExp = ')(a+b))';

console.log('The expression ' + correctExp + ' has only correctly put brackets: ' + correctBrackets(correctExp));
result.innerHTML += 'The expression ' + correctExp + ' has only correctly put brackets: ' + correctBrackets(correctExp) + '<br />';
console.log('The expression ' + incorrectExp + ' has only correctly put brackets: ' + correctBrackets(incorrectExp));
result.innerHTML += 'The expression ' + incorrectExp + ' has only correctly put brackets: ' + correctBrackets(incorrectExp);

function correctBrackets(expression) {
    var i,
        count = 0;

    for (var i = 0; i < expression.length; i++) {
        if (expression[0] === '(') {
            count += 1;
        } else if (expression[0] === ')') {
            count -= 1;
            if (count < 0) {
                return false;
            }
        }
    }

    return true;
}

