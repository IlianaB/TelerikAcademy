/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(start, end) {
    var result = [],
        maxDivisor,
        isPrime;

    if (arguments.length < 2) {
        throw new Error('You must specify start and end of the range!');
    }
    if (isNaN(parseInt(start)) || isNaN(parseInt(end))) {
        throw new Error('The arguments must be convertible to Number!');
    }

    start = parseInt(start, 10);
    end = parseInt(end, 10);

    for (var i = start; i <= end; i++) {
        maxDivisor = Math.sqrt(i);
        isPrime = true;

        if (i <= 1) {
            isPrime = false;
        }

        for (var j = 2; j <= maxDivisor; j++) {
            if (!(i % j)) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            result.push(i);
        }
    }

    return result;
}

module.exports = findPrimes;