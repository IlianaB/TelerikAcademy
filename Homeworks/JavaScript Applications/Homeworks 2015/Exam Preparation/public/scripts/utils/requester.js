var requester = (function () {
    function getTemplate(url) {
        return $.get(url);
    }

    return {
        getTemplate: getTemplate
    }
}());
