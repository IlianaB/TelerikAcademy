/*
 Problem 4. Number of elements
 Write a function to count the number of div elements on the web page
 */

var result = document.getElementById('result');

var divs = document.getElementsByTagName('div');
var numberOfDivs = divs.length;

console.log('The divs on the page are: ' + numberOfDivs);
result.innerHTML += 'The divs on the page are: ' + numberOfDivs;