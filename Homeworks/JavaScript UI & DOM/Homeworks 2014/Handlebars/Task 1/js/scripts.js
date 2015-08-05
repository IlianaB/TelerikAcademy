var data = {
    courses: [
        {
            id: 1,
            title: 'JavaScript',
            date: '21 July 2014'
        },
        {
            id: 2,
            title: 'C#',
            date: '22 July 2014'
        },
        {
            id: 3,
            title: 'HTML',
            date: '23 July 2014'
        },
        {
            id: 4,
            title: 'CSS',
            date: '24 July 2014'
        }
    ]
};

var result = document.getElementById('result'),
    template = document.getElementById('template').innerHTML,
    postTemplate = Handlebars.compile(template);

result.innerHTML = postTemplate(data);