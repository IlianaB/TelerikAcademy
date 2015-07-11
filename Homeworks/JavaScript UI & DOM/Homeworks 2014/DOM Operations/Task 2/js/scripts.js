/*
 2. Write a script that creates 5 div elements and moves them in circular path with interval of 100 milliseconds
 */

var dfg = document.createDocumentFragment(),
    divElement = document.createElement('div'),
    currentDiv;

divElement.style.display = 'inline-block';
divElement.style.width = '150px';
divElement.style.height = '150px';
divElement.style.border = '2px solid purple';
divElement.style.marginRight = '25px';
divElement.style.position = 'relative';
divElement.style.top = "200px";
divElement.style.left = "100px";

for (var i = 0; i < 5; i++) {
    currentDiv = divElement.cloneNode(true);

    dfg.appendChild(currentDiv);
}

document.body.appendChild(dfg);

animate();

var angle = 3 * Math.PI / 180;
var radius = 40;

function animate() {
    var divs = document.getElementsByTagName('div'),
        length = divs.length,
        current;

    // increase the angle of rotation
    angle += 20 * Math.PI / 180;

    for (var i = 0; i < length; i++) {
        current = divs[i];

        // calculate the new x / y
        var newX = parseInt(current.style.top, 10) + radius * Math.cos(angle);
        var newY = parseInt(current.style.left, 10) + radius * Math.sin(angle);

        current.style.top = newX + 'px';
        current.style.left = newY + 'px';
    }

    setTimeout(animate, 100);
}


