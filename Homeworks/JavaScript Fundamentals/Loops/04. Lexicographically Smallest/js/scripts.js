/*
 Problem 4. Lexicographically smallest
 Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
 */

var result = document.getElementById('result');

console.log('The smallest lexicographically property of document is: ' + findLexicographicallySmallestProperty(document));
result.innerHTML += 'The smallest lexicographically property of document is: ' + findLexicographicallySmallestProperty(document) + '<br />';

console.log('The largest lexicographically property of document is: ' + findLexicographicallyLargestProperty(document));
result.innerHTML += 'The largest lexicographically property of document is: ' + findLexicographicallyLargestProperty(document) + '<br />';


console.log('The smallest lexicographically property of window is: ' + findLexicographicallySmallestProperty(window));
result.innerHTML += 'The smallest lexicographically property of window is: ' + findLexicographicallySmallestProperty(window) + '<br />';

console.log('The largest lexicographically property of window is: ' + findLexicographicallyLargestProperty(window));
result.innerHTML += 'The largest lexicographically property of window is: ' + findLexicographicallyLargestProperty(window) + '<br />';


console.log('The smallest lexicographically property of navigator is: ' + findLexicographicallySmallestProperty(navigator));
result.innerHTML += 'The smallest lexicographically property of navigator is: ' + findLexicographicallySmallestProperty(navigator) + '<br />';

console.log('The largest lexicographically property of navigator is: ' + findLexicographicallyLargestProperty(navigator));
result.innerHTML += 'The largest lexicographically property of navigator is: ' + findLexicographicallyLargestProperty(navigator) + '<br />';


function findLexicographicallySmallestProperty(objectToSearch) {
    var smallest = 'zzzzzzzz';

    for (var prop in objectToSearch) {
        if(smallest > prop) {
            smallest = prop;
        }
    }

    return smallest;
}

function findLexicographicallyLargestProperty(objectToSearch) {
    var largest = 'A';

    for (var prop in objectToSearch) {
        if(largest < prop) {
            largest = prop;
        }
    }

    return largest;
}

