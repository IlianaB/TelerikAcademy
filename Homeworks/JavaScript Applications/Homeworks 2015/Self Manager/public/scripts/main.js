var app = Sammy('#content', function () {
    if (localStorage.getItem('authKey')) {
        $('#logout-btn').show();
    }

    this.get('#/', function () {
        var router = this;
        router.redirect('#/home');
    });

    this.get('#/home', function () {
        var router = this;

        $('#logout-btn').on('click', function () {
            localStorage.removeItem('authKey');
            router.redirect('#/home');
        });

        requester.getTemplate('views/home.html')
            .then(function (template) {
                renderer.render('#view', template, {
                    authKey: localStorage.getItem('authKey')
                });
            });
    });

    this.post('#/register', function (context) {
        var router = this;

        user.register(context.params.registerUsername, context.params.registerPassword)
            .then(function (data) {
                $('#logout-btn').show();

                console.log('Successfully registered' + data);
                notifier.showSuccessMessage('You are successfully registered!');
                localStorage.setItem('authKey', data.result.authKey);

                router.redirect('#/home');
            }, function (data) {
                console.log('Error' + data);
                notifier.showErrorMessage(JSON.parse(data.responseText).err);
            });
    });

    this.put('#/login', function (context) {
        var router = this;

        user.logIn(context.params.loginUsername, context.params.loginPassword)
            .then(function (data) {
                $('#logout-btn').show();

                console.log(data);
                notifier.showSuccessMessage('You are successfully loggedIn!');
                localStorage.setItem('authKey', data.result.authKey);

                router.redirect('#/home');
            }, function (data) {
                console.log(data);
                notifier.showErrorMessage(JSON.parse(data.responseText).err);
            });
    });

    this.get('#/logout', function () {
        var router = this;

        localStorage.removeItem('authKey');

        $('#logout-btn').hide();
        router.redirect('#/');
    });

    this.get('#/users', function () {
        var router = this;

        user.getAll()
            .then(function (data) {
                requester.getTemplate('views/users.html')
                    .then(function (template) {
                        renderer.render('#view', template, data.result);
                    });
            });
    });

    this.get('#/todos', function () {
        var router = this;

        todos.getAll()
            .then(function (data) {
                console.log(data);

                var groupedTodos = _.chain(data.result)
                    .groupBy(function (todo) {
                        return todo.category.toLowerCase()
                    })
                    .value();

                requester.getTemplate('views/todos.html')
                    .then(function (template) {
                        renderer.render('#view', template, groupedTodos);

                        $('#todosList').on('change', 'label', function () {
                            var $element = $(this),
                                $child = $element.find('input'),
                                id = $child.data('id'),
                                currentTODO;
                            console.log($element);

                            todos.getAll()
                                .then(function (data) {
                                    currentTODO = data.result.filter(function (todo) {
                                        return todo.id == id;
                                    });

                                    currentTODO[0].state = !currentTODO[0].state;

                                    todos.update(currentTODO[0]);
                                })
                        });

                        categories.getAll()
                            .then(function (data) {
                                //console.log(data);
                                $('#todoCategory').autocomplete({
                                    source: data.result
                                });
                            })
                    });
            });
    });

    this.post('#/todos', function () {
        var router = this,
            data = {
                text: $('#todoText').val(),
                category: $('#todoCategory').val()
            };

        todos.add(data)
            .then(function () {
                router.redirect('#/todos');
            })
    });

    this.get('#/todos/category=:category', function (context) {
        var router = this,
            category = context.params.category;

        todos.getAll()
            .then(function (data) {
                var groupedTodos = _.chain(data.result)
                    .groupBy(function (todo) {
                        return todo.category.toLowerCase()
                    })
                    .value();

                var templateData = {};
                templateData[category] = groupedTodos[category];

                requester.getTemplate('views/todos.html')
                    .then(function (template) {
                        renderer.render('#view', template, templateData);

                        $('#todosList').on('change', 'label', function () {
                            var $element = $(this),
                                $child = $element.find('input'),
                                id = $child.data('id'),
                                currentTODO;
                            console.log($element);

                            currentTODO = data.result.filter(function (todo) {
                                return todo.id == id;
                            });

                            currentTODO[0].state = !currentTODO[0].state;

                            todos.update(currentTODO[0]);

                        });

                        categories.getAll()
                            .then(function (data) {
                                //console.log(data);
                                $('#todoCategory').autocomplete({
                                    source: data.result
                                });
                            })
                    });
            });
    });

    this.get('#/events', function () {
        var router = this;

        events.getAll()
            .then(function (data) {
                requester.getTemplate('views/events.html')
                    .then(function (template) {
                        renderer.render('#view', template, data.result);
                    });
            });
    });

    this.get('#/events/add', function () {
        requester.getTemplate('views/addEvent.html')
            .then(function (template) {
                renderer.render('#view', template, {});

                categories.getAll()
                    .then(function (data) {
                        $('#category').autocomplete({
                            source: data.result
                        });
                    });

                user.getAll()
                    .then(function (data) {
                        $('#users').kendoMultiSelect({
                            dataTextField: "username",
                            dataValueField: "username",
                            dataSource: data.result
                        });
                    });

                $('#date').datepicker();
                $('#time').timepicker();
            });
    });

    this.post('#/events/add', function (context) {
        var router = this,
            params = context.params;

        events.add({
            title: params.title,
            category: params.category,
            description: params.description,
            date: params.date + ' ' + params.time,
            users: params.users
        }).then(function (data) {
            router.redirect('#/events')
        }, function (err) {
            notifier.showErrorMessage('Error!');
        })

    });
});

app.run('#/');
