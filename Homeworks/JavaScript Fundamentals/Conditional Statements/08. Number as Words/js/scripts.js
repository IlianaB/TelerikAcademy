/*
 Problem 8. Number as words
 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 */

var result = document.getElementById('result');
var number = 738;

if (number < 0 || number > 999) {
    console.log('Invalid number!');
    result.innerHTML += 'Invalid number!';
} else if (number < 10) {
    console.log(units(number, true));
    result.innerHTML += units(number, true);
} else if (number < 20) {
    console.log(tenToNighteen(number));
    result.innerHTML += tenToNighteen(number);
} else if (number < 100) {
    console.log(tenths(Math.floor(number / 10)));
    result.innerHTML += tenths(Math.floor(number / 10));
    console.log(units(number % 10, false).toLowerCase());
    result.innerHTML += units(number % 10, false).toLowerCase();
} else if (number < 1000) {
    console.log(hundreds(Math.floor(number / 100)));
    result.innerHTML += hundreds(Math.floor(number / 100));

    if (number % 100 < 10) {
        if (number % 100 != 0) {
            console.log('and ');
            result.innerHTML += 'and ';
        }
        console.log(units(number % 100, false).toLowerCase());
        result.innerHTML += units(number % 100, false).toLowerCase();
    } else if (number % 100 < 20) {
        console.log('and ');
        result.innerHTML('and ');
        console.log(tenToNighteen(number % 100).toLowerCase());
        result.innerHTML += tenToNighteen(number % 100).toLowerCase();
    } else {
        if (Math.floor(number / 10) % 10 !== 0) {
            console.log('and ');
            result.innerHTML += 'and ';
        }
        console.log(tenths(Math.floor(number / 10) % 10).toLowerCase());
        result.innerHTML += tenths(Math.floor(number / 10) % 10).toLowerCase();

        if (Math.floor(number / 10) % 10 !== 0) {
            console.log(units(number % 10, false).toLowerCase());
            result.innerHTML += units(number % 10, false).toLowerCase();
        }
    }
}

function units(number, showZero) {
    var result = '';
    switch (number) {
        case 0:
            result = 'Zero';
            break;
        case 1:
            result = 'One';
            break;
        case 2:
            result = 'Two';
            break;
        case 3:
            result = 'Three';
            break;
        case 4:
            result = 'Four';
            break;
        case 5:
            result = 'Five';
            break;
        case 6:
            result = 'Six';
            break;
        case 7:
            result = 'Seven';
            break;
        case 8:
            result = 'Eight';
            break;
        case 9:
            result = 'Nine';
            break;
    }

    if (!showZero && result == 'Zero') {
        result = '';
    }

    return result;
}

function tenToNighteen(number) {
    var result = '';
    switch (number) {
        case 10:
            result = 'Ten';
            break;
        case 11:
            result = 'Eleven';
            break;
        case 12:
            result = 'Twelve';
            break;
        case 13:
            result = 'Thirteen';
            break;
        case 14:
            result = 'Fourteen';
            break;
        case 15:
            result = 'Fifteen';
            break;
        case 16:
            result = 'Sixteen';
            break;
        case 17:
            result = 'Seventeen';
            break;
        case 18:
            result = 'Eighteen';
            break;
        case 19:
            result = 'Nineteen';
            break;
    }

    return result;
}

function tenths(number) {
    var result = '';
    switch (number) {
        case 2:
            result = 'Twenty ';
            break;
        case 3:
            result = 'Thirty ';
            break;
        case 4:
            result = 'Forty ';
            break;
        case 5:
            result = 'Fifty ';
            break;
        case 6:
            result = 'Sixty ';
            break;
        case 7:
            result = 'Seventy ';
            break;
        case 8:
            result = 'Eighty ';
            break;
        case 9:
            result = 'Ninety ';
            break;
    }

    return result;
}

function hundreds(number) {
    var result = '';
    switch (number) {
        case 1:
            result = 'One hundred ';
            break;
        case 2:
            result = 'Two hundred ';
            break;
        case 3:
            result = 'Three hundred ';
            break;
        case 4:
            result = 'Four hundred ';
            break;
        case 5:
            result = 'Five hundred ';
            break;
        case 6:
            result = 'Six hundred ';
            break;
        case 7:
            result = 'Seven hundred ';
            break;
        case 8:
            result = 'Eight hundred ';
            break;
        case 9:
            result = 'Nine hundred ';
            break;
    }

    return result;
}