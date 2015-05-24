/*
 Problem 7. First larger than neighbours
 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */

var result = document.getElementById('result');

var myArray = [1, 2, 6, 18, 6, 22, 15, 14, 6, 23],
    myArray2 = [1, 2, 3, 4, 5, 6];

console.log('The first number in the first array which is larger than its neighbours is at position ' + findFirstLarger(myArray));
result.innerHTML += 'The first number in the first array which is larger than its neighbours is at position ' + findFirstLarger(myArray) + '<br />';
console.log('The first number in the second array which is larger than its neighbours is at position ' + findFirstLarger(myArray2));
result.innerHTML += 'The first number in the second array which is larger than its neighbours is at position ' + findFirstLarger(myArray2);

function findFirstLarger(arr) {
    var condition = false;
    for (var position = 1; position < arr.length - 1; position++) {
        condition = false;

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
        if (arr.length === 1) {
            condition = false;
        }
        if (condition) {
            return position;
        }
    }

    if (!condition) {
        return -1;
    }

}
