/*
 Problem 6. Quadratic equation
 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.
 */

var result = document.getElementById('result');

var a = 2,
    b = 5,
    c = -3;

solveQuadraticEquation(a, b, c);

function solveQuadraticEquation(a, b, c) {
    var discriminant = Math.pow(b, 2) - 4 * a * c;

    if (discriminant < 0)
    {
        console.log('no real roots');
        result.innerHTML += 'no real roots';
    }
    else if (discriminant == 0)
    {
        console.log(-b / (2 * a));
        result.innerHTML += 'x1 = x2 =' + (-b / (2 * a));
    }
    else
    {
        var arr = [];
        arr[0] = (-b - Math.sqrt(discriminant)) / (2 * a);
        arr[1] = (-b + Math.sqrt(discriminant)) / (2 * a);

        console.log('x1 = ' + arr[0] + '; x2 = ' + arr[1]);
        result.innerHTML += 'x1 = ' + arr[0] + '; x2 = ' + arr[1];
    }
}
