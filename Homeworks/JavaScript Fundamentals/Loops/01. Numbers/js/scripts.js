/*
 Problem 1. Numbers
 Write a script that prints all the numbers from 1 to N.
 */

var result = document.getElementById('result');

var n = 15;

console.log('All numbers between 1 and ' + n + ' are: ');
result.innerHTML += 'All numbers between 1 and ' + n + ' are: ';

printNumbersInRange(n);

function printNumbersInRange(number){
    for (var i = 1; i <= n; i++) {
        console.log(i);
        result.innerHTML += i;

        if(i != n) {
            console.log(', ');
            result.innerHTML += ', ';
        }
    }
}


