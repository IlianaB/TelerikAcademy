/*
 Problem 8. Replace tags
 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

var result = document.getElementById('result');

var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log('Sentence with replaced <a> tags: ' + replaceTags(input));
result.innerHTML += 'Sentence with replaced <a> tags: ' + replaceTags(input);

function replaceTags(input) {
    var result;
    result = input.replace(/<a href="([^"]+)">([^<]+)<\/a>/gi, '[URL=$1]$2[/URL]');

    return result;
}