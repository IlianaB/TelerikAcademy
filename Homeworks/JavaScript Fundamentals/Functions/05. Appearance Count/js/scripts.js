/*
 Problem 5. Appearance count
 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */

var result = document.getElementById('result');

var myArray = [ 1, 2, 6, 18, 6, 22, 6, 14, 6],
    number = 6;

console.log('The number  ' + number + ' appears ' + findAppearances(myArray, number) + ' time(s) in the given array.');
result.innerHTML += 'The number  ' + number + ' appears ' + findAppearances(myArray, number) + ' time(s) in the given array.';

function findAppearances(arr, number) {
    var count = 0;

    for (var i = 0, len = arr.length; i < len; i++) {
        if (number === arr[i]) {
            count++;
        }
    }
    return count;
}
