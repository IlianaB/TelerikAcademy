/*
 Problem 2. HTML binding

 Write a function that puts the value of an object into the content/attributes of HTML tags.
 Add the function to the String.prototype
 Example 1:

 input

 var str = '<div data-bind-content="name"></div>';
 str.bind(str, {name: 'Steven'});
 output

 <div data-bind-content="name">Steven</div>
 Example 2:

 input

 var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>'
 str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
 output

 <a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</à>
 */

var result = document.getElementById('result');

var test = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';


if (!String.prototype.bind) {
    String.prototype.bind = function (model) {
        var result;

        result = this.replace(/.*data\-bind\-content="(\w+)".*/g, function (match, firstGroup) {
            var index = match.indexOf('>');
            return match.slice(0, index + 1) + model[firstGroup] + match.slice(index + 1);
        });

        result = result.replace(/.*data\-bind\-href="(\w+)".*/g, function (match, firstGroup) {
            var index = match.indexOf('>');
            return match.slice(0, index) + ' href="' + model[firstGroup] + '"' + match.slice(index);
        });

        result = result.replace(/.*data\-bind\-class="(\w+)".*/g, function (match, firstGroup) {
            var index = match.indexOf('>');
            return match.slice(0, index) + ' class="' + model[firstGroup] + '"' + match.slice(index);
        });

        return result;
    };
}

console.log(test.bind({name: 'Elena', link: 'http://telerikacademy.com'}));
result.innerText += test.bind({name: 'Elena', link: 'http://telerikacademy.com'});

