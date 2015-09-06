var thread = (function () {
    function getAll() {
        return $.ajax({
            url: 'api/threads',
            method: 'GET',
            contentType: 'application/json'
        })
    }

    function add(thread) {
        return $.ajax({
            url: 'api/threads',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(thread),
            headers: {
                'x-authKey': localStorage.getItem('authKey')
            }
        })
    }

    function getById(id) {
        return $.ajax({
            url: 'api/threads/' + id,
            method: 'GET',
            contentType: 'application/json'
        })
    }

    function addMessage(id, content) {
        return $.ajax({
            url: 'api/threads/' + id + '/messages',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify({
                text: content
            }),
            headers: {
                'x-authKey': localStorage.getItem('authKey')
            }
        });
    }

    return {
        getAll: getAll,
        add: add,
        getById: getById,
        addMessage: addMessage
    };
}());
