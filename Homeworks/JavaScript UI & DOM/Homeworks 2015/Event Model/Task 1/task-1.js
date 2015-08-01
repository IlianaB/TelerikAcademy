/* globals $ */

/* 

 Create a function that takes an id or DOM element and:


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