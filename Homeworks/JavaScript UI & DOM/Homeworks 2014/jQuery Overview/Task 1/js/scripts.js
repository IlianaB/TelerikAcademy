/*
 Create a slider control using jQuery
 The slider can have many slides
 Only one slide is visible at a time
 Each slide contains HTML code
 i.e. it can contain images, forms, divs, headers, links, etc…
 Implement functionality for changing the visible slide after 5 seconds
 Create buttons for next and previous slide
 */

var $ul = $('ul.slider')
    .on('click', changeSlidesOnButtonClick);

console.log($ul);

function changeSlidesOnButtonClick(event) {
    var $target = $(event.target).parent();

    $target.toggleClass('active');

    if ($target.next().length !== 0) {
        $target.next().toggleClass('active');
    } else {
        $target.parents('.slider')
            .find('li:first-child')
            .toggleClass('active');
    }
}
