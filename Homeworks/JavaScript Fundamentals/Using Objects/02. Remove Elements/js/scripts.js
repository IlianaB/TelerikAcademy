/*
 Problem 2. Remove elements
 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.
 */

var result = document.getElementById('result');

var myArr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

if (!Array.prototype.remove) {
    Array.prototype.remove = function (arg) {
        for (var i = 0; i < this.length; i++) {
            if (this[i] === arg) {
                this.splice(i, 1);
            }
        }
    }
}

myArr.remove(1);

console.log('After removing the number 1 in the array its elements are: ');
console.log(myArr.join(', '));
console.log('Notice that the last "1" is a string, not a number. That is why it is not removed!');
result.innerHTML += 'After removing the number 1 in the array its elements are: ' + '<br />' + myArr.join(', ') + '<br />' + 'Notice that the last "1" is a string, not a number. That is why it is not removed!';


