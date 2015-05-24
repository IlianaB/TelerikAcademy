/*
 Problem 3. Rectangle area
 Write an expression that calculates rectangle’s area by given width and height.
 */

var result = document.getElementById('result');

var width = 3,
    height = 4;

console.log('The area of a rectangle with width = ' + width + ' and height = ' + height + ' is: ' + calculateRectangleArea(width, height));
result.innerHTML += 'The area of a rectangle with width = ' + width + ' and height = ' + height + ' is: ' + calculateRectangleArea(width, height);

function calculateRectangleArea(width, height) {
    return width * height;
}

