/*
 Problem 4. Sort 3 numbers
 Sort 3 real values in descending order.
 Use nested if statements.
 Note: Don’t use arrays and the built-in sorting functionality.
 */

var result = document.getElementById('result');

var a = 5,
    b = 1,
    c = 2;

var first,
    second,
    third;

sortThreeNumbers(a, b, c);
console.log(first + ' ' + second + ' ' + third);
result.innerHTML += 'Numbers ' + a + ', ' + b + ' and ' + c + ' ordered in descending order: ' + first + ' ' + second + ' ' + third;

function sortThreeNumbers(a, b, c) {
    if (a >= b) {
        if (a >= c) {
            first = a;

            if (b >= c) {
                second = b;
                third = c;
            }
            else {
                second = c;
                third = b;
            }
        }
        else {
            first = c;
            second = a;
            third = b;
        }
    }
    else {
        if (b >= c) {
            first = b;

            if (a >= c) {
                second = a;
                third = c;
            }
            else {
                second = c;
                third = a;
            }
        }
        else {
            first = c;
            second = b;
            third = a;
        }
    }
}
