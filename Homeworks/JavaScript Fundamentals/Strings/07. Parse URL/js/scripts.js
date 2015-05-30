/*
 Problem 7. Parse URL
 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 */

var result = document.getElementById('result');

var urlAddress = 'http://telerikacademy.com/Courses/Courses/Details/239',
    newObject;

newObject = parseURL(urlAddress);
printResult(newObject);

function parseURL(urlAddress) {
    var protocol = '',
        server = '',
        resource = '',
        endProt,
        startServ,
        endServ,
        myObject;

    endProt = urlAddress.indexOf('://');
    protocol = urlAddress.substring(0, endProt);

    startServ = endProt + 3;
    endServ = urlAddress.indexOf('/', startServ);
    server = urlAddress.substring(startServ, endServ);

    resource = urlAddress.substring(endServ);

    myObject = {
        'protocol': protocol,
        'server': server,
        'resource': resource
    };

    return myObject;
}

function printResult(newObject) {
    for (var property in newObject) {
        if (newObject.hasOwnProperty(property)) {
            console.log(property + ': ' + newObject[property]);
            result.innerHTML += property + ': ' + newObject[property] + '<br />';
        }
    }
}
