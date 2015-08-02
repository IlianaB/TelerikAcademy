$.fn.gallery = function (columns) {
    var columns = columns || 4,
        $this = $(this).addClass('gallery'),
        $galleryList = $this.find('.gallery-list'),
        $selected = $this.find('.selected').hide().on('click', 'img', onItemClick),
        $prevSelected = $selected.find("#previous-image"),
        $currentSelected = $selected.find("#current-image"),
        $nextSelected = $selected.find("#next-image"),
        $images = $this.find('.image-container > img').on('click', onGalleryImageClick),
        $prevImage,
        $nextImage;

    $images.each(function (index, elem) {
        if (index % columns === 0) {
            $(elem).parent().addClass('clearfix');
        }
    });

    function onGalleryImageClick() {
        var $currentImage = $(this),
            currentIndex = parseInt($currentImage.attr('data-info'), 10);

        $prevImage = currentIndex === 1 ? $images.last() : $images.eq(currentIndex - 2);
        $nextImage = currentIndex === $images.length ? $images.first() : $images.eq(currentIndex);

        $currentSelected.attr('src', $currentImage.attr('src'));
        $prevSelected.attr('src', $prevImage.attr('src'));
        $nextSelected.attr('src', $nextImage.attr('src'));

        $galleryList.addClass('blurred');
        $selected.show();
    }

    function onItemClick() {
        var $navItem = $(this),
            navItemId = $navItem.attr('id');

        if (navItemId === 'current-image') {
            $selected.hide();
            $galleryList.removeClass('blurred');
        } else if (navItemId === 'previous-image') {
            $prevImage.trigger('click');
        } else {
            $nextImage.trigger('click');
        }
    }
};
