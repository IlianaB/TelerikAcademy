/*
 Problem 3. Min/Max of sequence
 Write a script that finds the max and min number from a sequence of numbers.
 */

var result = document.getElementById('result');

var sequence = [3, 5, 15, 2, 29, 14, 23, 18, 100, 1, 20];

console.log('Min number in the sequence is: ' + findMin(sequence) + ' Max number in the sequence is: ' + findMax(sequence));
result.innerHTML += 'Min number in the sequence is: ' + findMin(sequence) + '<br />' + 'Max number in the sequence is: ' + findMax(sequence);


function findMin(sequence) {
    var min = Number.MAX_VALUE;

    for (var i = 0, len = sequence.length; i <= len; i++) {
        if (sequence[i] < min) {
            min = sequence[i];
        }
    }

    return min;
}

function findMax(sequence) {
    var max = Number.MIN_VALUE;

    for (var i = 0, len = sequence.length; i <= len; i++) {
        if (sequence[i] > max) {
            max = sequence[i];
        }
    }

    return max;
}
