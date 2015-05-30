/*
 Problem 3. Sub-string in text

 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */

var result = document.getElementById('result');

var text = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
    word = 'in';

console.log('Occurrences of the word "' + word + '" in the text are: ' + findOccurrences(text, word));
result.innerHTML += 'Occurrences of the word "' + word + '" in the text are: ' + findOccurrences(text, word);

function findOccurrences(text, word) {
    var result,
        regex = new RegExp(word, 'gi');
    result = text.match(regex).length;

    return result;
}