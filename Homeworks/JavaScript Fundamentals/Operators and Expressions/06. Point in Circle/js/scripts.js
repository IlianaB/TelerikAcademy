/*
 Problem 6. Point in Circle
 Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
 */

var result = document.getElementById('result');

var xCircle = 0;
var yCircle = 0;
var radiusCircle = 5;

var xFirstPoint = 0;
var yFirstPoint = 1;

var xSecondPoint = -4;
var ySecondPoint = 5;

console.log('The point with x = ' + xFirstPoint + ' and y = ' + yFirstPoint + ' is within a circle K(0, 5): ' + checkIfInCircle(xFirstPoint, yFirstPoint, xCircle, yCircle, radiusCircle));
result.innerHTML += 'The point with x = ' + xFirstPoint + ' and y = ' + yFirstPoint + ' is within a circle K(0, 5): ' + checkIfInCircle(xFirstPoint, yFirstPoint, xCircle, yCircle, radiusCircle) + '<br />';
console.log('The point with x = ' + xSecondPoint + ' and y = ' + ySecondPoint + ' is within a circle K(0, 5): ' + checkIfInCircle(xSecondPoint, ySecondPoint, xCircle, yCircle, radiusCircle));
result.innerHTML += 'The point with x = ' + xSecondPoint + ' and y = ' + ySecondPoint + ' is within a circle K(0, 5): ' + checkIfInCircle(xSecondPoint, ySecondPoint, xCircle, yCircle, radiusCircle) + '<br />';

function checkIfInCircle(xPoint, yPoint, x, y, radius) {
    return ((xPoint - x) * (xPoint - x) + (yPoint - y) * (yPoint - y) < radius * radius);
}
