(function () {
    var $nameInput = $('#input-name'),
        $gradeInput = $('#input-grade'),
        $addButton = $('#add-button'),
        $deletedButton = $('#delete-button'),
        resourceUrl = 'http://localhost:3000/students';

    $addButton.on('click', onAddButtonClick);
    $deletedButton.on('click', onDeleteButtonClick);

    var addStudent = function (data) {
        return $.ajax({
            url: resourceUrl,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json'
        });
    };

    var deleteStudent = function (data) {
        return $.ajax({
            url: resourceUrl + '/' + data.id,
            type: 'DELETE',
            data: JSON.stringify(data),
            contentType: 'application/json'
        });
    };

    var getStudents = function () {
        return $.ajax({
            url: resourceUrl,
            type: 'GET',
            contentType: 'application/json'
        })
    };

    function onAddButtonClick() {
        var studentName = $nameInput.val(),
            studentGrade = $gradeInput.val(),
            student = {
                name: studentName,
                grade: studentGrade
            };

        addStudent(student)
            .then(getStudents)
            .then(updateTheDOM);
    }

    function onDeleteButtonClick() {
        var studentID = $('#delete-input').val();

        deleteStudent({id: studentID})
            .then(getStudents)
            .then(updateTheDOM, errorNoExistingStudent);
    }

    function updateTheDOM(data) {
        var result = $('.students-data');
        var template = $('#template').html();
        var postTemplate = Handlebars.compile(template);

        result.html(postTemplate(data));
    }

    function errorNoExistingStudent() {
        alert('There is no student with the provided ID or something bad happened!');
    }

}());
