/*
 Problem 6. Most frequent number
 Write a script that finds the most frequent number in an array.
 */

var result = document.getElementById('result');

myArray = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var count = 1,
    max = 0,
    number;

findMostFrequentNumber(myArray);
printResult();

function findMostFrequentNumber(arr) {
    for (var i = 0, len = myArray.length; i < len; i++) {
        for (var j = i + 1; j < len; j++) {
            if (myArray[i] === myArray[j]) {
                count++;

                if (max < count) {
                    max = count;
                    number = myArray[i];
                }
            }
        }
        count = 1;
    }
}

function printResult() {
    console.log('The most frequent number in the array is: ' + number + '. It can be seen ' + max + ' times.');
    result.innerHTML += 'The most frequent number in the array is: ' + number + '. It can be seen ' + max + ' times.';
}
