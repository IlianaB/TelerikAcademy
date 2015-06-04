/*
 Problem 1. Planar coordinates
 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */

var result = document.getElementById('result');

var pointA = new Point(12, 3),
    pointB = new Point(10, 6),
    lineA = new Line(new Point(3, 6), new Point(8, 12)),
    lineB = new Line(new Point(5, 1), new Point(8, 3)),
    lineC = new Line(new Point(10, 6), new Point(15, 8));

console.log('The distance between pointA and pointB is: ' + calculateDistance(pointA, pointB).toFixed(2));
result.innerHTML += 'The distance between pointA and pointB is: ' + calculateDistance(pointA, pointB).toFixed(2) + '<br />';

console.log('The lineA, lineB and lineC can form a triangle: ' + canFormTriangle(lineA.length, lineB.length, lineC.length));
result.innerHTML += 'The lineA, lineB and lineC can form a triangle: ' + canFormTriangle(lineA.length, lineB.length, lineC.length);

function Point(x, y) {
    this.x = x;
    this.y = y;
}


function Line(pointStart, pointEnd) {
    this.start = pointStart;
    this.end = pointEnd;
}

Line.prototype.getLength = function () {
    calculateDistance(this.start, this.end);
};


function calculateDistance(pointA, pointB) {
    var xd = pointA.x - pointB.x,
        yd = pointA.y - pointB.y,
        distance = Math.sqrt(xd * xd + yd * yd);

    return distance;
}

function canFormTriangle(a, b, c) {
    if ((a + b > c) && (b + c > a) && (a + c > b)) {
        return true;
    }

    return false;
}