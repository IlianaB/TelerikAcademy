/* globals $ */

/* 

 Task 1

 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element


 */

function solve() {
    return function Test(selector) {
        var element = null,
            allButtons,
            buttonsLength,
            currButton;

        if (typeof  selector === 'string') {
            element = document.getElementById(selector);
        } else if (selector.nodeType === 1) {
            element = selector;
        } else {
            throw new Error();
        }

        if (element === null) {
            throw  new Error();
        }

        allButtons = element.getElementsByClassName('button');
        buttonsLength = allButtons.length;

        for (var i = 0; i < buttonsLength; i++) {
            currButton = allButtons[i];

            currButton.innerHTML = 'hide';
            currButton.addEventListener('click', onBtnClick);
        }

        function onBtnClick() {
            var nextContent = this.nextElementSibling,
                nextBtn = this.nextElementSibling;

            while (nextContent.className !== 'content') {
                nextContent = nextContent.nextElementSibling;
            }

            if (nextContent && nextContent.className === 'content') {
                while (nextBtn.className !== 'button') {
                    nextBtn = nextBtn.nextElementSibling;
                }
            }

            if (nextBtn.className === 'button') {
                if (nextContent.style.display === 'none') {
                    nextContent.style.display = '';
                    this.innerHTML = 'hide';
                } else {
                    nextContent.style.display = 'none';
                    this.innerHTML = 'show';
                }
            }
        }

    };
};

module.exports = solve;