/*
 Create a jQuery plugin for creating dropdown list
 By given the following:
 <select id="dropdown">
 <option value="1">One</option>
 <option value="2">Two</option>
 </select>

 $('#dropdown').dropdown()

 Produces the following HTML:
 <select id="dropdown" style="display: none">…</select>
 <div class="dropdown-list-container">
 <ul class="dropdown-list-options">
 <li class="dropdown-list-option" data-value="0">One</li>
 …
 </ul>
 </div>

 And make it work as SELECT node
 Selecting an one of the generated LI nodes, selects the corresponding OPTION node
 So $('#dropdown:selected') works

 */

$.fn.dropdown = function () {
    this.each(function (index, elem) {
        var $element = $(elem),
            $options = $element.children();

        $element.css({
            'display': 'none'
        });

        var $div = $('<div>').insertAfter($element).addClass('dropdown-list-container'),
            $ul = $('<ul>').addClass('dropdown-list-options');
        $div.append($ul);

        for (var i = 0; i < $options.length; i++) {
            var $option = $($options[i]),
                dataValue = $option.attr('value'),
                innerTxt = $option.text(),
                $li = $('<li>').addClass('dropdown-list-option')
                    .attr('data-value', dataValue)
                    .text(innerTxt)
                    .appendTo($ul);
        }

        $ul.on('click', 'li', onClickSelect);

        function onClickSelect () {
            var $li = $(this),
                val = $li.attr('data-value');

            /*$element.find('[value=' + val + ']').attr('selected', 'selected');*/
            $element.val(val);

        }
    });

    return this;
};

$('#dropdown').dropdown();
console.log($('#dropdown :selected')[0]);