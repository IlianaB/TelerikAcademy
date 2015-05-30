/*
 Problem 1. Reverse string
 Write a JavaScript function that reverses a string and returns it.
 */

var result = document.getElementById('result');

var text = 'sample';

console.log('The word ' + text + ' in reversed order is: ' + reverseText(text));
result.innerHTML += 'The word ' + text + ' in reversed order is: ' + reverseText(text);

function reverseText(text) {
    var i,
        res = '';

    for (i = text.length - 1; i >= 0; i--) {
        res += text[i];
    }

    return res;
}
