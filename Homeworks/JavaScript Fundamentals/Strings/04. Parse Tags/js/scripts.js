/*
 Problem 4. Parse tags
 You are given a text. Write a function that changes the text in all regions:
 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 */

var result = document.getElementById('result');

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';
res = replaceUpper(text);
res = replaceLower(res);
res = replaceMix(res);

console.log('The sentence with parsed tags is: ' + res);
result.innerHTML += 'The sentence with parsed tags is: ' + res;

function replaceUpper(text) {
    var result;
    result = text.replace(/<upcase>([^<]+)<\/upcase>/gi, function (match, firstGroup) {
        return firstGroup.toUpperCase();
    });

    return result;
}

function replaceLower(text) {
    var result;
    result = text.replace(/<lowcase>([^<]+)<\/lowcase>/gi, function (match, firstGroup) {
        return firstGroup.toLowerCase();
    });

    return result;
}

function replaceMix(text) {
    var result;

    result = text.replace(/<mixcase>([^<]+)<\/mixcase>/gi, function (match, firstGroup) {
        return makeMixcase(firstGroup);
    });

    function makeMixcase(word) {
        var i,
            number,
            res = '';

        for (i = 0; i < word.length; i++) {
            number = Math.round(Math.random());

            switch (number) {
                case 0:
                    res += word[i].toLowerCase();
                    break;
                case 1:
                    res += word[i].toUpperCase();
                    break;
            }
        }

        return res;
    }

    return result;
}