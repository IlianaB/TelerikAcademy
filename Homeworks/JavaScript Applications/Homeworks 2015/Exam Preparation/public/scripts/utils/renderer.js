var renderer = (function () {
    function render(selector, view, data) {
        var template = compileTemplate(view, data);

        $(selector).html(template);
    }

    function appendToDOM(selector, view, data) {
        var template = compileTemplate(view, data);

        $(selector).append(template);
    }

    function getTemplate(path) {
        return $.ajax({
            url: path
        });
    }

    function compileTemplate(view, data) {
        var template = Handlebars.compile(view),
            compiledTemplate = template(data);

        return compiledTemplate;
    }

    return {
        render: render,
        appendToDOM: appendToDOM,
        getTemplate: getTemplate
    }
}());
