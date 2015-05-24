/*
 Problem 7. Binary search
 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

var result = document.getElementById('result');

var myArray = [1, 4, 24, 54, 22, 17, 8, 20, 29, 3, 15, 34, 23, 11];

//the sorted array looks like this:  1, 3, 4, 8, 11, 15, 17, 20, 22, 23, 24, 29, 34, 54


function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1;
};

myArray.sort(orderBy);

var start = 0,
    end = myArray.length - 1;
middle = Math.floor(myArray.length / 2);
number = 20;

while (start < end) {
    if (number < myArray[start] || number > myArray[end]) {
        console.log('There is no such number in the array!');
        result.innerHTML += 'There is no such number in the array!';
        break;
    }
    else if (number < myArray[middle]) {
        end = middle;
        middle = Math.floor((end - start) / 2) + start;

        if (middle == end) {
            middle--;
        }
    }
    else if (number > myArray[middle]) {
        start = middle;
        middle = Math.floor((end - start) / 2) + start;

        if (middle == start) {
            middle++;
        }
    }
    else if (number == myArray[middle]) {
        console.log('The index of' + number + 'in the array is: ' + middle);
        result.innerHTML += 'The index of ' + number + ' in the array is: ' + middle;
        break;
    }
}