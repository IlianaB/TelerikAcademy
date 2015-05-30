/*
 Problem 11. String format
 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 */

var result = document.getElementById('result');

var str = stringFormat('Hello {0}!', 'Peter'),
    frmt = '{0}, {1}, {0} text {2}',
    str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');

console.log(str);
console.log(str2);
result.innerHTML += str + '<br />';
result.innerHTML += str2;

function stringFormat() {
    var i,
        regex,
        exp,
        formattedString = arguments[0];

    for (i = 1; i < arguments.length; i++) {
        exp = '{[' + (i - 1) + ']}';
        regex = new RegExp(exp, 'g');
        formattedString = formattedString.replace(regex, arguments[i]);
    }

    return formattedString;
}
