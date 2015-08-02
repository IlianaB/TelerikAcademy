function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector),
        leftCont = document.createElement('div'),
        rightCont = document.createElement('div'),
        textBox = document.createElement('input'),
        imagesCont = document.createElement('div'),
        filter = document.createElement('h4'),
        length = items.length,
        currImage,
        currImageTitle,
        currImageUrl,
        imageTitle = document.createElement('figcaption'),
        imageFigure = document.createElement('figure'),
        imgFigure,
        imageFigcaptionTitle,
        imgTag = document.createElement('img'),
        imageImgTag,
        titleLeft = document.createElement('h2'),
        imgLeft = document.createElement('img'),
        firstElementTitle = items[0].title,
        firstElementUrl = items[0].url,
        srcAttribute,
        value,
        allImgFigures,
        currImgFigure,
        figuresLength,
        currentClicked;

    leftCont.style.float = 'left';
    rightCont.style.float = 'right';

    leftCont.style.padding = '15px';
    rightCont.style.padding = '15px';

    //Filter
    filter.style.margin = '0';
    filter.style.padding = '0';
    filter.innerHTML = 'Filter';

    textBox.setAttribute('type', 'text');
    textBox.setAttribute('id', 'textBox');
    textBox.addEventListener('input', inputOnChange);

    rightCont.appendChild(filter);
    rightCont.appendChild(textBox);
    rightCont.appendChild(imagesCont);

    //Right image styles
    imageTitle.style.margin = '0';
    imageTitle.style.padding = '0';

    imgTag.style.width = '200px';

    imageFigure.style.padding = '10px';
    imageFigure.style.margin = '10px';

    //Creating left content box
    titleLeft.innerHTML = firstElementTitle;
    imgLeft.setAttribute('src', firstElementUrl);
    imgLeft.style.width = '250px';

    leftCont.appendChild(titleLeft);
    leftCont.appendChild(imgLeft);

    //Creating right content box
    for (var i = 0; i < length; i++) {
        currImage = items[i];
        currImageTitle = currImage.title;
        currImageUrl = currImage.url;

        imgFigure = imageFigure.cloneNode(true);
        imgFigure.setAttribute('id', currImageTitle);
        imageFigcaptionTitle = imageTitle.cloneNode(true);
        imageFigcaptionTitle.innerHTML = currImageTitle;

        imageImgTag = imgTag.cloneNode(true);
        imageImgTag.setAttribute('src', currImageUrl);

        imgFigure.appendChild(imageFigcaptionTitle);
        imgFigure.appendChild(imageImgTag);

        //Attaching events on image tags
        imgFigure.addEventListener('mouseover', imageOnMouseOver);
        imgFigure.addEventListener('mouseout', imageOnMouseOut);
        imgFigure.addEventListener('click', imageOnClick);

        imagesCont.appendChild(imgFigure);
    }

    rightCont.appendChild(imagesCont);

    //Append left content box and right content box to the main div container
    container.style.width = '550px';
    container.appendChild(leftCont);
    container.appendChild(rightCont);

    function imageOnMouseOver() {
        this.style.background = 'lightgray';
    }

    function imageOnMouseOut() {
        if (!this.classList.contains('clicked')) {
            this.style.background = '';
        }
    }

    function imageOnClick() {
        currentClicked = rightCont.querySelector('.clicked');

        if (currentClicked) {
            currentClicked.classList.remove('clicked');
            currentClicked.style.background = '';
        }

        this.style.background = 'lightgray';
        this.classList.add('clicked');

        srcAttribute = this.childNodes[1].getAttribute('src');
        titleLeft.innerHTML = this.childNodes[0].innerText;
        imgLeft.setAttribute('src', srcAttribute);
    }

    function inputOnChange() {
        value = document.getElementById("textBox").value.toLowerCase();
        allImgFigures = rightCont.getElementsByTagName('figure');
        figuresLength = allImgFigures.length

        for (var i = 0; i < figuresLength; i++) {
            currImgFigure = allImgFigures[i];

            if (currImgFigure.getAttribute('id').toLowerCase().indexOf(value) < 0) {
                currImgFigure.style.display = 'none';
            } else {
                currImgFigure.style.display = '';
            }
        }
    }
}