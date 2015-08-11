(function () {
    var $nameInput = $('#name'),
        $messageInput = $('#message'),
        $sendButton = $('#send-button'),
        $ulChat = $('#chat-zone'),
        resourseUrl = 'http://crowd-chat.herokuapp.com/posts';

    $sendButton.on('click', onSendButtonClick);

    function onSendButtonClick() {
        var objToSend = {
            'user': $nameInput.val(),
            'text': $messageInput.val()
        };

        $nameInput.val('');
        $messageInput.val('');

        makePostRequestToServer(objToSend)
            .then(getAllPosts, showError)
            .then(updateTheDOM, showError);
    }

    function makePostRequestToServer(obj) {
        return $.ajax({
            url: resourseUrl,
            type: 'POST',
            data: obj
        })
    }

    function getAllPosts() {
        return $.ajax({
            url: resourseUrl,
            type: 'GET'
        })
    }

    function updateTheDOM(data) {
        var lastMessage = data[data.length - 1],
            author = lastMessage.by,
            message = lastMessage.text,
            color,
            date;

        if (data.length % 2 == 0) {
            color = 'success';
        } else {
            color = 'warning'
        }

        date = getCurrentDate();

        $ulChat.append('<li class="list-group-item list-group-item-' + color + '"><p><strong>Author:</strong> '
            + author + '<p><strong>Date: </strong>' + date + '</p></p><p><strong>Message:</strong> ' + message + '</p></li><p></p>'
        );
    }

    function getCurrentDate() {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1;
        var yyyy = today.getFullYear();

        if (dd < 10) {
            dd = '0' + dd
        }

        if (mm < 10) {
            mm = '0' + mm
        }

        today = mm + '/' + dd + '/' + yyyy;

        return today;
    }


    function showError() {
        alert('Something bad happened!');
    }

}());
