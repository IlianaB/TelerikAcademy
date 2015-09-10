var post = (function () {
    function getAll() {
        return $.ajax({
            url: '/post',
            method: 'GET',
            contentType: 'application/json'
        })
    }

    function create(data) {
        return $.ajax({
            url: '/post',
            method: 'POST',
            data: JSON.stringify(data),
            headers: {
                'X-SessionKey': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    return {
        getAll: getAll,
        create: create
    }
}());
