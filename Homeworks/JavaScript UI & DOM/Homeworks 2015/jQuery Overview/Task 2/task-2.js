/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {
        if (typeof selector !== 'string') {
            throw new Error();
        }

        var $selectedElement = $(selector),
            $allButtons = $selectedElement.find('.button');

        if (!$selectedElement.length) {
            throw new Error();
        }

        for (var i = 0; i < $allButtons.length; i++) {
            var $currElement = $($allButtons[i]);
            $currElement.text('hide');

            $currElement.on('click', onBtnCLick);
        }

        function onBtnCLick() {
            var $this = $(this);

            var $nextBtn = $this.next('.button'),
                $nextContent = $this.next('.content');

            if ($nextBtn.length && $nextContent.length) {
                if ($nextContent.css('display') === 'none') {
                    $nextContent.css('display', '');
                    $this.text('hide');
                } else {
                    $nextContent.css('display', 'none');
                    $this.text('show');
                }
            }
        }
    };
};

module.exports = solve;