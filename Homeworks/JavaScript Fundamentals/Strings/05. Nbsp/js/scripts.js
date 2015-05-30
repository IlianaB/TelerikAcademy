/*
 Problem 5. nbsp
 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

var result = document.getElementById('result');

var text = 'Write a function that replaces non breaking white-spaces in a text';

console.log('Sentence with replaces white spaces: ' + replaceWhiteSpaces(text));
result.innerHTML += 'The result can be seen only in the console!';


function replaceWhiteSpaces(text) {
    var result,
        regex;

    regex = new RegExp(' ', 'g');
    result = text.replace(regex, '&nbsp;');

    return result;
}


