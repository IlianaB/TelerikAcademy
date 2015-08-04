$.ajax({
    url: 'http://api.openweathermap.org/data/2.5/forecast?q=London,us&mode=json'
}).done(function (data) {
    result.innerHTML = postTemplate(data);
});

var result = document.getElementById('result'),
    template = document.getElementById('template').innerHTML,
    postTemplate = Handlebars.compile(template);


