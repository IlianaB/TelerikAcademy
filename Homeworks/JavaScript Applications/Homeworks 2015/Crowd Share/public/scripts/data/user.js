var user = (function () {
    function register(username, password) {
        var authCode = CryptoJS.SHA1(username + password).toString();
        var data = {
            username: username,
            authCode: authCode
        };

        return $.ajax({
            url: '/user',
            method: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json'
        })
    }

    function logIn(username, password) {
        var data = {
            username: username,
            authCode: CryptoJS.SHA1(username + password).toString()
        };

        return $.ajax({
            url: '/auth',
            method: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json'
        })
    }

    function logOut() {
        return $.ajax({
            url: '/user',
            method: 'PUT',
            headers: {
                'X-SessionKey': localStorage.getItem('authKey')
            },
            contentType: 'application/json'
        })
    }

    return {
        register: register,
        logIn: logIn,
        logOut: logOut
    }
}());