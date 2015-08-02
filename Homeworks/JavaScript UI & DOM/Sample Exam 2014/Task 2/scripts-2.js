$.fn.gallery = function (columns) {
    var columns = columns || 4,
        $gallery = $(this).addClass('gallery'),
        $selected = $gallery.find('.selected'),
        $allImgs = $gallery.find('.image-container'),
        imagesLength = $allImgs.length,
        $currImg,
        $previousClicked,
        $nextClicked,
        currentDataInfo,
        prevDataInfo,
        nextDataInfo;

    //$gallery.css('width', columns * 250 + columns * 10);
    $allImgs.each(function (index, elem) {
        if (index % columns === 0) {
            $(elem).addClass('clearfix');
        }
    });
    $selected.hide();

    //Add Event handler on image containers
    for (var i = 0; i < imagesLength; i++) {
        $currImg = $($allImgs[i]);

        $currImg.on('click', onImgClick);
    }

    //Add Event handler on selected
    $selected.on('click', 'img', onSelectedClick);

    function onImgClick() {
        var $this = $(this),
            $oldClicked = $selected.find('.current-image'),
            $oldPrevious = $selected.find('.previous-image'),
            $oldNext = $selected.find('.next-image');

        currentDataInfo = $this.find('img').attr('data-info');

        if (currentDataInfo == 1) {
            prevDataInfo = imagesLength;
        } else {
            prevDataInfo = parseInt(currentDataInfo, 10) - 1;
        }

        if (currentDataInfo == imagesLength) {
            nextDataInfo = 1;
        } else {
            nextDataInfo = parseInt(currentDataInfo, 10) + 1;
        }

        $previousClicked = $gallery.find('[data-info=' + prevDataInfo + ']');
        $nextClicked = $gallery.find('[data-info=' + nextDataInfo + ']');

        if ($oldClicked !== $this) {
            $oldClicked.find('img').attr('src', $this.find('img').attr('src'));
            $oldPrevious.find('img').attr('src', $previousClicked.attr('src'));
            $oldNext.find('img').attr('src', $nextClicked.attr('src'));
        }

        $selected.show();
        $gallery.find('.gallery-list').addClass('blurred');
    }

    function onSelectedClick() {
        var $this = $(this);

        if ($this.attr('id') === 'current-image') {
            $selected.hide();
        }

        if ($this.attr('id') === 'previous-image') {
            $previousClicked.trigger('click');
        }

        if ($this.attr('id') === 'next-image') {
            $nextClicked.trigger('click');
        }

    }
};