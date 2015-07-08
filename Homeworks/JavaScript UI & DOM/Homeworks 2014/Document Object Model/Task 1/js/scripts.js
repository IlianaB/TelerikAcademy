/*
 1. Write a script that selects all the div nodes that are directly inside other div elements
 Create a function using querySelectorAll()
 Create a function using getElementsByTagName()
 */

console.log('Divs selected through querySelectorAll: ');
printResult(selectDivsWithQuerySelectorAll());
console.log('Divs selected through getElementsByTagName: ');
printResult(selectDivsWithGetElements());

function selectDivsWithQuerySelectorAll() {
    var allDivs = document.querySelectorAll('div > div');

    return allDivs;
}

function selectDivsWithGetElements() {
    var allDivs = document.getElementsByTagName('div'),
        directNodes = [],
        length = allDivs.length,
        currentDiv;

    for (var i = 0; i < length; i++) {
        currentDiv = allDivs[i];

        if (currentDiv.parentNode.nodeName === 'DIV') {
            directNodes.push(currentDiv);
        }
    }

    return directNodes;
}

function printResult(collection) {
    for (var i = 0; i < collection.length; i++) {
        console.log(collection[i]);
    }
}
