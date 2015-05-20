/*
 Problem 8. Trapezoid area
 Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

var result = document.getElementById('result');

var a1 = 5,
    b1 = 7,
    h1 = 12;

var a2 = 8.5,
    b2 = 4.3,
    h2 = 2.7;

console.log(calculateTrapezoidArea(a1, b1, h1));
result.innerHTML += 'The trapezoid with a = ' + a1 + ', b = ' + b1 + ' and h = ' + h1 + ' is: ' + calculateTrapezoidArea(a1, b1, h1) + '<br />';
console.log(calculateTrapezoidArea(a2, b2, h2));
result.innerHTML += 'The trapezoid with a = ' + a2 + ', b = ' + b2 + ' and h = ' + h2 + ' is: ' + calculateTrapezoidArea(a2, b2, h2) + '<br />';

function calculateTrapezoidArea(a, b, h) {
    return ((a + b) / 2) * h;
}
