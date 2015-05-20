/*
 Problem 1. Increase array members
 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

var result = document.getElementById('result');

var myArray = [];

for (var i = 0; i < 20; i++) {
    myArray[i] = i * 5;
}

console.log(myArray.join(', '));
result.innerHTML += myArray.join(', ');