/*
 Problem 9. Extract e-mails
 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */

var result = document.getElementById('result');

var text = 'Hello, osama@bin-laden.af, you have been using this@email.com in your registration.',
    emailMatches = text.match(/[A-Z0-9._-]+@[A-Z0-9.-]+\.[A-Z]{2,4}/gi);

console.log('Matched emails in the text: ');
result.innerHTML += 'Matched emails in the text: ' + '<br />';

for (var i = 0; i < emailMatches.length; i++) {
    console.log(emailMatches[i]);
    result.innerHTML += emailMatches[i] + '<br />';
}

