/*
 Problem 2. Numbers not divisible
 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */

var result = document.getElementById('result');

var n = 30;

console.log('All numbers between 1 and ' + n + ' that are not divisible by 3 and 7 at the same time are: ' + '<br />');
result.innerHTML += 'All numbers between 1 and ' + n + ' that are not divisible by 3 and 7 at the same time are: ' + '<br />';

notDivisibleBy3And7(n);

function notDivisibleBy3And7(number) {
    for (var i = 0; i <= n; i++) {
        if(i % 3 != 0 || i % 7 != 0) {
            console.log(i);
            result.innerHTML += i;

            if(i != n) {
                console.log(', ');
                result.innerHTML += ', ';
            }
        }
    }
}