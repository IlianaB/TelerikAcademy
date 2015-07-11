/*
 *Create a TreeView component
 Initially only the top items must be visible
 On item click
 If its children are hidden (collapsed), they must be made visible (expanded)
 If its children are visible (expanded), they must be made hidden (collapsed)
 Research about events
 */

document.querySelector('body > ul').addEventListener('click', function (event) {
    var currentElement = event.target;

    currentElement.classList.toggle('visible');
});