/*
 Create a to do list with the following UI controls
 Form input for new Item
 Button for adding the new Item
 Button for deleting some item
 Show and Hide Button
 */

var $addButton = $('#add-item');

$addButton.on('click', onButtonClickAddItem);

function onButtonClickAddItem(event) {
    var $inputFieldValue = $('#add-input').val(),
        $currLi,
        $delBtn,
        $showBtn,
        $hideBtn;

    event.preventDefault();

    $('#TODO-list').append('<li><span>' + $inputFieldValue + '</span></li>');

    $currLi = $('#TODO-list').find('li:last-child');

    $delBtn = $('<button class="del-btn">Delete</button>').on('click', delButton);
    $showBtn = $('<button class="show-btn">Show</button>').on('click', showButton);
    $hideBtn = $('<button class="hide-btn">Hide</button>').on('click', hideButton);
    $currLi.append($delBtn)
            .append($showBtn)
            .append($hideBtn);
}


function showButton(event) {
    event.preventDefault();

    var $siblingSpan = $(this).prevAll('span');
    $siblingSpan.show();
}

function hideButton(event) {
    event.preventDefault();

    var $siblingSpan = $(this).prevAll('span');
    $siblingSpan.hide();
}

function delButton(event) {
    event.preventDefault();

    var $parentNode = $(this).parent();
    $parentNode.remove();
}