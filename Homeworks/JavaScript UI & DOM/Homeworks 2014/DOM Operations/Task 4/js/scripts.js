/*
 Create a tag cloud:
 Visualize a string of tags (strings) in a given container
 By given minFontSize and maxFontSize, generate the tags with different font-size, depending on the number of occurrences
 */

var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web",
    "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];

var tagCloud = generateTagCloud(tags, 17, 42);

function generateTagCloud(tags, minFontSize, maxFontSize) {
    var dictionary = makeDictionary(tags),
        dfg = createSpans(dictionary, minFontSize, maxFontSize);

    document.body.appendChild(dfg);
}

function makeDictionary(collection) {
    var length = collection.length,
        currentTag,
        dictionary = {};

    for (var i = 0; i < length; i++) {
        currentTag = collection[i];

        if (!dictionary[currentTag]) {
            dictionary[currentTag] = 0;
        }
        dictionary[currentTag]++;
    }

    return dictionary;
}

function createSpans(dictionary, minFontSize, maxFontSize) {
    var spanElement = document.createElement('span'),
        dfg = document.createDocumentFragment(),
        newSpan;

    for (var prop in dictionary) {
        newSpan = spanElement.cloneNode(true);
        newSpan.innerText = prop;
        newSpan.style.fontSize = (minFontSize + dictionary[prop] * 5) + 'px';
        dfg.appendChild(newSpan);
    }

    return dfg;
}