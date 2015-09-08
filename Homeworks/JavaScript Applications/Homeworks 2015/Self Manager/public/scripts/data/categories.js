var categories = (function () {
    function getAll() {
        return $.ajax({
            url: 'api/categories',
            method: 'GET',
            headers: {
                'x-auth-key': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    return {
        getAll: getAll
    }
}());