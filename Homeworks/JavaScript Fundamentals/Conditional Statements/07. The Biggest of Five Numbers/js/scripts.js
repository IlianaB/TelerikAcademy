/*
 Problem 7. The biggest of five numbers
 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 */

var result = document.getElementById('result');

var a = 5,
    b = 2,
    c = 2,
    d = 4,
    e = 1;

console.log('The biggest number is: ' + findBiggestNumber(a, b, c, d, e));
result.innerHTML += 'The biggest number is: ' + findBiggestNumber(a, b, c, d, e);

function findBiggestNumber(a, b, c, d, e) {
    var biggestNumber = a;

    if (biggestNumber <= b)
    {
        biggestNumber = b;
    }
    if (biggestNumber <= c)
    {
        biggestNumber = c;
    }
    if (biggestNumber <= d)
    {
        biggestNumber = d;
    }
    if (biggestNumber <= e)
    {
        biggestNumber = e;
    }

    return biggestNumber;
}
