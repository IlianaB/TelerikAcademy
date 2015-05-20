/*
 Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */

var result = document.getElementById('result');

var myArray = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

var count = 1,
    max = 0,
    number;

for (var i = 0; i < myArray.length - 1; i++) {
    if (myArray[i] === myArray[i + 1]) {
        count++;

        if (max < count) {
            max = count;
            number = myArray[0];
        }
    }
    else {
        count = 1;
    }
}

console.log('The maximal sequence of equal elements in the array is: ');
result.innerHTML += 'The maximal sequence of equal elements in the array is: ';

for (var i = 0; i < max; i++) {
    console.log(number);
    result.innerHTML += number;

    if (i !== max - 1) {
        console.log(', ');
        result.innerHTML += ', ';
    }
}