/*
 Using jQuery implement functionality to insert a DOM element before or after another element
 */

$('<h2>The best music is here!</h2>').insertAfter('h1');
$('p').before('<img src="images/Friend Smiley.png" width="50" height="50"/>');

var $h2Element = $('h2');

$h2Element.after('<h3>...and more!</h3>');