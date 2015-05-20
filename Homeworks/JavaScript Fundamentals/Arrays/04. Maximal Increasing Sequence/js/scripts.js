/*
 Problem 4. Maximal increasing sequence
 Write a script that finds the maximal increasing sequence in an array.
 */

var result = document.getElementById('result');

var myArray = [3, 2, 3, 4, 2, 2, 4];
var bestSequence = [];

var count = 1,
    temp = 0,
    maxCount = 0;

for (var i = 0; i < myArray.length - 1; i++) {
    if (myArray[i] < myArray[i + 1]) {
        temp = i;
        while (myArray[temp] < myArray[temp + 1]) {
            temp++;
            count++;

            if (temp == myArray.length - 1) {
                break;
            }
        }

        if (maxCount < count) {
            maxCount = count;
            bestSequence = [];

            for (var j = i; j < i + maxCount; j++) {
                bestSequence.push(myArray[j]);
            }

        }
        count = 1;
    }
    else {
        count = 1;
    }
}

console.log('The maximal increasing sequence is: ');
result.innerHTML += 'The maximal increasing sequence is: ';

console.log(bestSequence.join(', '));
result.innerHTML += bestSequence.join(', ');

