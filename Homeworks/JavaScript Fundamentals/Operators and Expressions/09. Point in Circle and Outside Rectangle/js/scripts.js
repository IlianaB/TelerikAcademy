/*
 Problem 9. Point in Circle and outside Rectangle
 Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

var result = document.getElementById('result');

var x1 = 1,
    y1 = 2;

var x2 = 2.5,
    y2 = 2;


console.log(checkCondition(isInsideCircle(x1, y1), isInsideRectangle(x1, y1)));
result.innerHTML += 'A poin with x = ' + x1 + ' and y = ' + y1 + ' is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2): ' + checkCondition(isInsideCircle(x1, y1), isInsideRectangle(x1, y1)) + '<br />';
console.log(checkCondition(isInsideCircle(x2, y2), isInsideRectangle(x2, y2)));
result.innerHTML += 'A poin with x = ' + x2 + ' and y = ' + y2 + ' is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2): ' + checkCondition(isInsideCircle(x2, y2), isInsideRectangle(x2, y2)) + '<br />';


function isInsideCircle(x, y) {
    var insideCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;

    return insideCircle;
}

function isInsideRectangle(x, y) {
    var insideRectangle = (x >= -1 && x <= 5 && y <= 1 && y >= -1);

    return insideRectangle;
}

function checkCondition(insideCircle, insideRectangle) {
    if ((insideCircle && insideRectangle) || (!insideCircle && !insideRectangle) || (!insideCircle && insideRectangle)) {
        return 'no';
    }
    else {
        return 'yes';
    }
}