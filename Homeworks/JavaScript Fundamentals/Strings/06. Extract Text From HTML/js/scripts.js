/*
 Problem 6. Extract text from HTML
 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 */

var result = document.getElementById('result');

var htmlText = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body </body></html>';

console.log('The text in the html page is: ' + extractText(htmlText));
result.innerHTML += 'The text in the html page is: ' + extractText(htmlText);

function extractText(text) {
    var i,
        inTag = false,
        result = '';
    for (i = 0; i < text.length; i += 1) {
        if (text[i] === '<') {
            inTag = true;
        } else if (text[i] === '>') {
            inTag = false;
        } else if (!inTag) {
            result += text[i];
        }
    }

    return result;
}