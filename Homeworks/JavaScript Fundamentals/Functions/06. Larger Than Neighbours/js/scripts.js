/**
 Problem 6. Larger than neighbours
 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */

var result = document.getElementById('result');

var myArray = [1, 2, 6, 18, 6, 22, 15, 14, 6, 23],
    position1 = 3,
    position2 = 6;

console.log('The number  ' + myArray[position1] + ' at position ' + position1 + ' is bigger than its two neighbours: ' + checkIfLarger(myArray, position1));
result.innerHTML += 'The number  ' + myArray[position1] + ' at position ' + position1 + ' is bigger than its two neighbours: ' + checkIfLarger(myArray, position1) + '<br />';
console.log('The number  ' + myArray[position2] + ' at position ' + position2 + ' is bigger than its two neighbours: ' + checkIfLarger(myArray, position2));
result.innerHTML += 'The number  ' + myArray[position2] + ' at position ' + position2 + ' is bigger than its two neighbours: ' + checkIfLarger(myArray, position2);

function checkIfLarger(arr, position) {
    var condition = false;

    if (arr.length === 1 || position === 0 || position === arr.length - 1) {
        return false;
    }
    if (position > 0) {
        if (arr[position] > arr[position - 1]) {
            condition = true;
        }
    }
    if (position < arr.length - 1) {
        if (arr[position] > arr[position + 1]) {
            condition = condition && true;
        }
        else {
            condition = condition && false;
        }
    }
    return condition;
}
