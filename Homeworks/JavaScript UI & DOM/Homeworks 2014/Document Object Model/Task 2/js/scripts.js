/*
 2. Create a function that gets the value of <input type="text"> ands prints its value to the console
 */

getInputValue();

function getInputValue() {
    var input = document.getElementsByTagName('input')[0];

    input.addEventListener('change', function (event) {
        console.log(event.target.value);
    });
}
