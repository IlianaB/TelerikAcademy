var events = (function () {
    function getAll() {
        return $.ajax({
            url: 'api/events',
            method: 'GET',
            headers: {
                'x-auth-key': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    function add(event) {
        return $.ajax({
            url: 'api/events',
            method: 'POST',
            data: JSON.stringify(event),
            headers: {
                'x-auth-key': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    return {
        getAll: getAll,
        add: add
    }
}());