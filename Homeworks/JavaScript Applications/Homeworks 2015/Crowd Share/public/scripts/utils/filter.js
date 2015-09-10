var filter = (function () {
    function filterByProp(collection, prop) {
        return _.filter(collection, function (item) {
            return item.user.username === prop;
        });
    }

    function filterByPattern(collection, pattern) {
        return _.filter(collection, function (item) {
            var title = item.title.toLowerCase(),
                body = item.body.toLowerCase(),
                searchPattern = pattern.toLowerCase();

            return title.indexOf(searchPattern) >= 0 || body.indexOf(searchPattern) >= 0;
        })
    }

    return {
        filterByProp: filterByProp,
        filterByPattern: filterByPattern
    }
}());
