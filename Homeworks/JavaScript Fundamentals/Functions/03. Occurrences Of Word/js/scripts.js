/*
 Problem 3. Occurrences of word
 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading..
 */

var result = document.getElementById('result');

var text = 'This is the text for this problem',
    word = 'this';

console.log('Searching the word  ' + '"' + word + '"' + ' in the text /case sensitive/: ' + findOccurrences(text, word) + ' occurrence(s).');
result.innerHTML += 'Searching the word  ' + '"' + word + '"' + ' in the text /case sensitive/: ' + findOccurrences(text, word) + ' occurrence(s).' + '<br />';
console.log('Searching the word  ' + '"' + word + '"' + ' in the text /case insensitive/: ' + findOccurrences(text, word, true) + ' occurrence(s).');
result.innerHTML += 'Searching the word  ' + '"' + word + '"' + ' in the text /case insensitive/: ' + findOccurrences(text, word, true) + ' occurrence(s).';

function findOccurrences(text, word, caseInsensitive) {
    var index = 0,
        count = 0;

    if (caseInsensitive) {
        word = word.toLowerCase();
        text = text.toLowerCase();
    }

    while (index != -1) {
        index = text.indexOf(word, index);

        if (index != -1) {
            index++;
            count++;
        }
    }
    return count;
}
