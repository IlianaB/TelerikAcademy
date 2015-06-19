/*
 Task 1.

 Write a function that sums an array of numbers:
 Numbers must be always of type Number
 Returns null if the array is empty
 Throws Error if the parameter is not passed (undefined)
 Throws if any of the elements is not convertible to Number
 */

function sum(arr) {
    var sum;

    if (arr === undefined) {
        throw new Error('You should pass an array with numbers!');
    }
    if (arr.length === 0) {
        return null;
    }

    sum = arr.reduce(function (sum, number) {
        if (isNaN(parseInt(number))) {
            throw  new Error('There should be only numbers in the array!');
        }
        return sum + parseInt(number);
    }, 0);

    return sum;
}

module.exports = sum;