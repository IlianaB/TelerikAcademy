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

        post.getAll()
            .then(function (data) {
                var withMomentFromNow = _.each(data, function (item) {
                    var date = new Date(item.postDate);

                    return item.momentFromNow = moment(date).fromNow();
                });

                requester.getTemplate('views/home.html')
                    .then(function (template) {
                        renderer.render('#view', template, {
                            authKey: localStorage.getItem('authKey'),
                            allPosts: withMomentFromNow
                        });

                        $('ul.pagination1').quickPagination({pageSize: '2'});
                    });
            });
    });

    this.post('#/register', function (context) {
        var router = this;

        user.register(context.params.registerUsername, context.params.registerPassword)
            .then(function (data) {
                console.log('Successfully registered' + data);
                notifier.showSuccessMessage('You are successfully registered! Please LogIn now!');
                //localStorage.setItem('authKey', data.result.authKey);

                router.redirect('#/home');
            }, function (data) {
                console.log('Error' + data);
                notifier.showErrorMessage(data.responseJSON.message);
            });
    });

    this.post('#/login', function (context) {
        var router = this;

        user.logIn(context.params.loginUsername, context.params.loginPassword)
            .then(function (data) {
                $('#logout-btn').show();

                console.log(data);
                notifier.showSuccessMessage('You are successfully loggedIn!');
                localStorage.setItem('authKey', data.sessionKey);

                router.redirect('#/home');
            }, function (data) {
                notifier.showErrorMessage(data.responseJSON.message);
            });
    });

    this.get('#/logout', function () {
        var router = this;

        user.logOut()
            .then(function () {
                localStorage.removeItem('authKey');
                $('#logout-btn').hide();
                router.redirect('#/');
            }, function (err) {
                console.log(err);
            });
    });

    this.get('#/createPost', function () {
        var router = this;

        requester.getTemplate('views/createPost.html')
            .then(function (template) {
                renderer.render('#view', template, {
                    authKey: localStorage.getItem('authKey')
                });
            });

    });

    this.post('#/createPost', function (context) {
        var router = this,
            data = {
                title: context.params.title,
                body: context.params.content
            };

        post.create(data)
            .then(function () {
                notifier.showSuccessMessage('The post is successfully created!');
                router.redirect('#/home');
            }, function (err) {
                console.log(err);
            });
    });

    this.post('#/post?', function (context) {
        var router = this,
            pattern = context.params.searchPattern,
            user = context.params.userFilter;

        post.getAll()
            .then(function (data) {
                var filtered;

                if (pattern && user) {
                    var filteredByUser = filter.filterByProp(data, user);
                    filtered = filter.filterByPattern(filteredByUser, pattern)
                } else if (pattern && pattern !== '') {
                    filtered = filter.filterByPattern(data, pattern);
                } else if (user && user !== '') {
                    filtered = filter.filterByProp(data, user);
                } else {
                    filtered = data;
                }

                var withMomentFromNow = _.each(filtered, function (item) {
                    var date = new Date(item.postDate),
                        hours = date.getHours();
                    return item.momentFromNow = moment().startOf('hour').fromNow();
                });

                requester.getTemplate('views/home.html')
                    .then(function (template) {
                        renderer.render('#view', template, {
                            authKey: localStorage.getItem('authKey'),
                            allPosts: withMomentFromNow
                        });

                        $('ul.pagination1').quickPagination({pageSize: '2'});
                    });
            });

    });
});

app.run('#/');
