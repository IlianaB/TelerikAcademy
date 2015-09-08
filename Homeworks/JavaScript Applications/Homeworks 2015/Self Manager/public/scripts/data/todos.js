var todos = (function () {
    function getAll() {
        return $.ajax({
            url: 'api/todos',
            method: 'GET',
            headers: {
                'x-auth-key': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    function add(data) {
        return $.ajax({
            url: 'api/todos',
            method: 'POST',
            data: JSON.stringify(data),
            headers: {
                'x-auth-key': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    function update(todo) {
        return $.ajax({
            url: 'api/todos/' + todo.id,
            method: 'PUT',
            data: JSON.stringify(todo),
            headers: {
                'x-auth-key': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    return {
        getAll: getAll,
        add: add,
        update: update
    }
}());
