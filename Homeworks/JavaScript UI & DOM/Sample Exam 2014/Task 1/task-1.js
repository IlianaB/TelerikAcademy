/* globals module */
function solve() {

    return function createImagesPreviewer(selector, items) {
        var container = document.querySelector(selector),
            main = document.createElement('main'),
            aside = document.createElement('aside'),
            filterBox = document.createElement('div'),
            filterTitle = document.createElement('h3'),
            filterInput = document.createElement('input'),
            imagesList = document.createElement('ul'),
            imageContainer = document.createElement('li'),
            imageTitle = document.createElement('h3'),
            image = document.createElement('img'),
            mainImage = document.createElement('img'),
            mainTitle = document.createElement('h2'),
            dfg = document.createDocumentFragment(),
            itemsLength = items.length,
            currLi,
            currImg,
            currTitle,
            currUrl,
            currentItem,
            allImgTags,
            imgTagsLength,
            currImg;

        container.style.width = '800px';

        dfg.appendChild(main);
        dfg.appendChild(aside);
        container.appendChild(dfg);

        main.style.float = 'left';
        main.style.width = '65%';
        main.className = 'image-preview';
        aside.style.float = 'right';
        aside.style.width = '35%';

        imagesList.style.listStyle = 'none';
        imagesList.style.height = '700px';
        imagesList.style.overflow = 'scroll';
        imagesList.style.padding = '0';
        imageContainer.style.padding = '10px';
        imageContainer.className = 'image-container';
        image.style.width = '100%';
        image.className = 'image';

        filterTitle.innerHTML = 'Filter';
        filterTitle.style.textAlign = 'center';
        filterInput.setAttribute('type', 'text');
        filterInput.style.width = '85%';
        filterInput.setAttribute('id', 'textInput');
        filterBox.appendChild(filterTitle);
        filterBox.appendChild(filterInput);
        aside.appendChild(filterBox);

        for (var i = 0; i < itemsLength; i++) {
            currentItem = items[i];

            currLi = imageContainer.cloneNode(true);
            currImg = image.cloneNode(true);
            currTitle = imageTitle.cloneNode(true);

            currTitle.innerHTML = currentItem.title;
            currUrl = currentItem.url;
            currImg.setAttribute('src', currUrl);
            currImg.setAttribute('data-value', currentItem.title);

            currLi.appendChild(currTitle);
            currLi.appendChild(currImg);

            imagesList.appendChild(currLi);
        }

        aside.appendChild(imagesList);

        mainImage.setAttribute('src', items[0].url);
        mainImage.style.width = '85%';
        mainTitle.innerHTML = items[0].title;
        main.appendChild(mainTitle);
        main.appendChild(mainImage);

        allImgTags = aside.getElementsByClassName('image');
        imgTagsLength = allImgTags.length;

        for (var i = 0; i < imgTagsLength; i++) {
            currImg = allImgTags[i];

            currImg.addEventListener('mouseover', onMouseOver);
            currImg.addEventListener('mouseout', onMouseOut);
        }

        imagesList.addEventListener('click', onImageClick);
        filterInput.addEventListener('keyup', onFilterInput);

        function onMouseOver(ev) {
            var target = ev.target.parentNode;

            target.style.background = 'lightgray';
        }

        function onMouseOut(ev) {
            var target = ev.target.parentNode;

            if (!(ev.target.id == 'selected')) {
                target.style.background = '';
            }
        }

        function onImageClick(ev) {
            var target = ev.target,
                title,
                currentSelected = document.getElementById('selected');

            if (!(currentSelected === target)) {
                if (currentSelected) {
                    currentSelected.parentNode.style.background = '';
                    currentSelected.removeAttribute('id');
                }

                target.style.background = 'lightgray';
                target.setAttribute('id', 'selected');
                title = target.previousElementSibling.innerText;
                mainImage.setAttribute('src', target.src);
                mainTitle.innerHTML = title;
            } else {
                target.style.background = '';
            }
        }

        function onFilterInput(ev) {
            var target = ev.target,
                value = target.value.toLowerCase(),
                currImg;

            for (var i = 0; i < imgTagsLength; i++) {
                currImg = allImgTags[i];

                if (currImg.getAttribute('data-value').toLowerCase().indexOf(value) < 0) {
                    currImg.parentNode.style.display = 'none';
                } else {
                    currImg.parentNode.style.display = '';
                }
            }
        }
    }
}

module.exports = solve;