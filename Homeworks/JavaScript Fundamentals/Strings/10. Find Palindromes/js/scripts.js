/*
 Problem 10. Find palindromes
 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

var result = document.getElementById('result');

var text = 'We made it to the next level! So now we know that ABBA, lamal and exe are palindromes!';

console.log('The palindromes in the text are: ');
console.log(findPalindromes(text).join(', '));
result.innerHTML += 'The palindromes in the text are: ' + '<br />' + findPalindromes(text).join(', ');

function findPalindromes(text) {
    var cleanedText,
        arr,
        i,
        j,
        isPalindrome = true,
        result = [];

    cleanedText = text.replace(/[!?,\.\s+]+/gi, ' ').trim();
    arr = cleanedText.split(' ');

    for (i = 0; i < arr.length; i++) {
        isPalindrome = true;
        for (j = 0; j < arr[i].length / 2; j++) {
            if (arr[i][j].toLowerCase() !== arr[i][arr[i].length - j - 1].toLowerCase()) {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome) {
            result.push(arr[i]);
        }
    }

    return result;
}

