/*
 Problem 2. Quoted text
 Create a string variable with quoted text in it.
 For example: `'How you doin'?', Joey said'.
 */

var result = document.getElementById('result');

var quotedText = '"How you doin\'?", Joey said.';

console.log(quotedText);
result.innerHTML += quotedText;
