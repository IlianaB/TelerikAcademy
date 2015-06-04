/*
 Problem 4. Has property

 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
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
    };

function hasProperty(obj, property) {
    for (var prop in obj) {
        if (prop === property) {
            return true;
        }
    }

    return false;
}

result.innerHTML += 'Object has property "address": ' + hasProperty(obj, "address") + '<br />';
result.innerHTML += 'Object has property "test":' + hasProperty(obj, "test");

console.log('Object has property "address": ' + hasProperty(obj, "address"));
console.log('Object has property "test": ' + hasProperty(obj, "test"));



