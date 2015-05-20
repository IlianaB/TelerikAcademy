/*
 Problem 7. Is prime
 Write an expression that checks if given positive integer number n (n ? 100) is prime.
 */

var result = document.getElementById('result');

var firstNumber = 1;
var secondNumber = 2;

console.log(checkIfPrime(firstNumber));
result.innerHTML += 'The number ' + firstNumber + ' is prime: ' + checkIfPrime(firstNumber) + '<br />';
console.log(checkIfPrime(secondNumber));
result.innerHTML += 'The number ' + secondNumber + ' is prime: ' + checkIfPrime(secondNumber) + '<br />';

function checkIfPrime(number) {
    if (number <= 1) {
        return false;
    }
    else {
        for (var i = 2; i <= number / 2; i++) {
            if (number % i == 0) {
                return false;
            }
        }
    }
    return true;
}
