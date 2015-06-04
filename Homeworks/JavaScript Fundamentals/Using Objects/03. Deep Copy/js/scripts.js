/*
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

var result = document.getElementById('result'),
    obj = {
        firstName: 'Pesho',
        lastName: 'Goshov',
        address: {
            country: 'Bulgaria',
            city: 'Sofia',
            postCode: '1000'
        }
    },
    copyObj = deepCopy(obj);

function deepCopy(obj) {
    var clone = {};

    for (var property in obj) {
        if (typeof obj[property] === 'object' && obj[property] !== null) {
            clone[property] = deepCopy(obj[property]);
        } else {
            clone[property] = obj[property]
        }
    }

    return clone;
}

function print(obj, indent) {
    for (var property in obj) {
        if (indent) {
            result.innerHTML += '&nbsp;&nbsp;&nbsp;&nbsp;';
        }

        if (typeof obj[property] === 'object' && obj[property] !== null) {
            print(obj[property], true);
        } else {
            result.innerHTML += property + ': ' + obj[property];
        }

        result.innerHTML += '<br />'
    }
}

result.innerHTML += 'Original object: <br />';
print(obj);
result.innerHTML += 'Cloned object: <br />';
print(copyObj);


console.log('Original object:')
console.log(obj);
console.log('Cloned object:');
console.log(copyObj);



