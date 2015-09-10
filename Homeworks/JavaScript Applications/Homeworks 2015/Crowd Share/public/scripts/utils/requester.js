var requester = (function () {
    function getTemplate(url) {
        return $.ajax(url);
    }

    return {
        getTemplate: getTemplate
    }
}());
