function createCalendar(id, events) {
    var container = document.querySelector(id),
        divDay = document.createElement('div'),
        dayTitle = document.createElement('h4'),
        dayContent = document.createElement('p'),
        dfg = document.createDocumentFragment(),
        dictionary = {};

    container.style.width = '1100px';

    divDay.style.display = 'inline-block';
    divDay.style.border = '1px solid black';
    divDay.style.width = '150px';
    divDay.style.verticalAlign = 'top';
    divDay.style.class = 'day';
    divDay.style.margin = '0';
    divDay.style.padding = '0';

    dayTitle.style.borderBottom = '1px solid black';
    dayTitle.style.margin = '0';
    dayTitle.style.padding = '0';
    dayTitle.style.background = 'lightgray';

    dayContent.style.height = '100px';
    dayContent.style.margin = '0';
    dayContent.style.padding = '0';


    var daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

    for (var i = 0; i < events.length; i++) {
        var currEv = events[i];
        var date = parseInt(currEv.date);

        dictionary[date] = currEv;
    }

    for (var i = 0; i < 30; i++) {
        var dayEvent = dictionary[i + 1];
        var newEl = divDay.cloneNode(true);
        var newTitle = dayTitle.cloneNode(true);
        var newP = dayContent.cloneNode(true);
        newTitle.innerHTML += daysOfWeek[i % 7] + ' ' + (i + 1) + ' June 2014';
        newEl.appendChild(newTitle);
        newEl.appendChild(newP);
        newEl.addEventListener('mouseover', mouseOver);
        newEl.addEventListener('mouseout', mouseOut);
        newEl.addEventListener('click', onClick);

        if (dayEvent) {
            newP.innerText = ' ' + dayEvent.hour + ' ' + dayEvent.title;
        }

        dfg.appendChild(newEl);
    }

    function mouseOver() {
        var target = this,
            title = target.querySelector('h4');

        title.style.background = 'skyblue';
    }

    function mouseOut() {
        var target = this,
            title = target.querySelector('h4');

        if (target.id.indexOf('selected') < 0) {
            title.style.background = 'lightgray';
        } else {
            title.style.background = 'pink';
        }

    }

    function onClick() {
        var oldSelected = document.getElementById('selected');

        if (oldSelected === this) {
            oldSelected.id = '';
            var oldH = oldSelected.querySelector('h4'),
                oldP = oldSelected.querySelector('p');
            oldH.style.background = 'lightgray';
            oldP.style.background = 'white';
        } else {
            if (oldSelected) {
                oldSelected.id = '';
                var oldH = oldSelected.querySelector('h4'),
                    oldP = oldSelected.querySelector('p');
                oldH.style.background = 'lightgray';
                oldP.style.background = 'white';
            }

            var target = this,
                title = target.querySelector('h4'),
                par = target.querySelector('p');

            target.id = 'selected';
            title.style.background = 'pink';
            par.style.background = 'pink';
        }
    }

    container.appendChild(dfg);
}