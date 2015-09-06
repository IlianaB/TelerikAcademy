var app = Sammy('#content', function () {
    this.get('#/', function () {
        requester.getTemplate('views/home.html')
            .then(function (template) {
                var authKey = localStorage.getItem('authKey');
                renderer.render('#view', template, {
                    authKey: authKey
                });
            });
    });

    this.post('#/register', function (context) {
        var router = this;

        user.register(context.params.registerUsername, context.params.registerPassword)
            .then(function (data) {
                localStorage.setItem('authKey', data.authKey);
                router.redirect('#/threads');
            }, function (data) {
                console.error(JSON.parse(data.responseText).err);
            });
    });

    this.post('#/login', function (context) {
        var router = this;

        user.logIn(context.params.loginUsername, context.params.loginPassword)
            .then(function (data) {
                localStorage.setItem('authKey', data.authKey);
                router.redirect('#/threads');
            }, function (data) {
                console.error(JSON.parse(data.responseText).err);
            });
    });

    this.get('#/threads', function () {
        thread.getAll()
            .then(function (data) {
                console.log(data);
                requester.getTemplate('../views/threads.html')
                    .then(function (template) {
                        renderer.render('#view', template, {
                            threads: data,
                            authKey: localStorage.getItem('authKey')
                        });
                    })
            });
    });

    this.post('#/threads', function (context) {
        var router = this;

        var currentThread = {
            title: context.params.threadTitle
        };

        thread.add(currentThread)
            .then(function (data) {
                router.redirect('#/threads/' + data.result.id);
            });
    });

    this.get('#/users', function () {
        user.getAll()
            .then(function (data) {
                requester.getTemplate('../views/users.html')
                    .then(function (template) {
                        renderer.render('#view', template, data);
                    })
            })
    });

    this.get('#/threads/:id', function (context) {
        thread.getById(context.params.id)
            .then(function (data) {
                console.log(data);
                requester.getTemplate('../views/thread.html')
                    .then(function (template) {
                        renderer.render('#view', template, data)
                    })
            })
    });

    this.post('#/threads/:id/messages', function (context) {
        var router = this,
            id = context.params.id,
            content = context.params.messageContent;

        thread.addMessage(id, content)
            .then(function () {
                router.redirect('#/threads/' + id);
            }, function () {
                debugger
            })
    });

    this.get('#/logout', function () {
        var router = this;

        localStorage.removeItem('authKey');

        router.redirect('#/');
    });
});

app.run('#/');