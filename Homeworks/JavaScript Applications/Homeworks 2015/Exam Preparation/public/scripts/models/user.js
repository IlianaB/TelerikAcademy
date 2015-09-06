var user = (function () {
    function register(username, password) {
        var data = {
            username: username,
            passHash: password
        };

        return $.ajax({
            url: 'api/users',
            method: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json'
        });
    }

    function logIn(username, passHash) {
        var data = {
            username: username,
            passHash: passHash
        };

        return $.ajax({
            url: 'api/auth',
            method: 'PUT',
            data: JSON.stringify(data),
            contentType: 'application/json'
        });
    }

    function getAll() {
        return $.ajax({
            url: 'api/users',
            method: 'GET',
            contentType: 'application/json'
        });
    }

    return {
        register: register,
        logIn: logIn,
        getAll: getAll
    };
}());