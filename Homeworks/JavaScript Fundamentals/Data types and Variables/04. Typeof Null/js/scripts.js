/*
 Problem 4. Typeof null
 Create null, undefined variables and try typeof on them.
 */

var result = document.getElementById('result');

var nullVariable = null;
var undefinedVariable;

console.log(typeof(nullVariable));
result.innerHTML += typeof(nullVariable) + '<br />';
console.log(typeof(undefinedVariable));
result.innerHTML += typeof(undefinedVariable);

