/*
 Problem 2. Lexicographically comparison
 Write a script that compares two char arrays lexicographically (letter by letter).
 */

var result = document.getElementById('result');

var firstArray = ['a', 'b', 'c'],
    secondArray = ['a', 'd', 'e'];

var length = firstArray.length < secondArray.length ? firstArray.length : secondArray.length;

for (var i = 0; i < length; i++) {
    if (firstArray[i] < secondArray[i]) {
        console.log('The first array is lexicographically before the second one.');
        result.innerHTML += 'The first array is lexicographically before the second one.';
        break;
    }
    else if (firstArray[i] > secondArray[i]) {
        console.log('The second array is lexicographically before the first one.');
        result.innerHTML += 'The second array is lexicographically before the first one.';
        break;
    }
}
