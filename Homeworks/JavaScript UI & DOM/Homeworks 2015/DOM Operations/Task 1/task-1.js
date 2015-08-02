/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

function solve() {

    return function (element, contents) {
        var item,
            length = contents.length,
            currentContent,
            newDiv,
            divElement,
            dfg = document.createDocumentFragment();

        if (typeof element !== 'string' && element.nodeType != 1) {
            throw new Error();
        }

        if (typeof element === 'string') {
            item = document.getElementById(element);

            if (!item) {
                throw new Error();
            }
        } else {
            item = element;
        }

        for (var i = 0; i < length; i++) {
            currentContent = contents[i];
            if (typeof currentContent !== 'string' && typeof currentContent !== 'number') {
                throw new Error();
            }
        }

        item.innerHTML = '';
        newDiv = document.createElement('div');

        for (var i = 0; i < length; i++) {
            divElement = newDiv.cloneNode(true);
            divElement.innerHTML = contents[i];
            dfg.appendChild(divElement);
        }

        item.appendChild(dfg);
    };
};

module.exports = solve;