/*
 Problem 5. Selection sort
 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */

var result = document.getElementById('result');

var numbers = [12, 3, 2, 5, -1, 7, 0, -14];

selectionSort(numbers);
printArray(numbers);

function selectionSort(numbers) {
    // The sorting logic:
    for (var i = 0; i < numbers.length - 1; i++) {
        // Loop that is operating over the un-sorted part of the array
        for (var j = i + 1; j < numbers.length; j++) {
            // Swapping the values
            if (numbers[i] > numbers[j]) {
                var helper = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = helper;
            }
        }
    }
}

function printArray(numbers) {
    console.log(numbers.join(', '));
    result.innerHTML += numbers.join(', ');
}
