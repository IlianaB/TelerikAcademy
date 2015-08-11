(function () {
    var numberToGuess,
        $guessButton = $('#guess-button'),
        $guessNumberInput = $('#guess-input'),
        $startButton = $('#start-game'),
        $guessesUl = $('#guesses'),
        $resultDiv = $('#result'),
        $nameButton = $('#name-button'),
        $winInput = $('#win-input'),
        allUsers = {players: []},
        tries,
        cows,
        bulls,
        id = 0;

    getAllUsersAndScores();
    printTopScores();

    $guessButton.on('click', onGuessButtonClick);
    $startButton.on('click', startTheGame);
    $nameButton.on('click', enterNameButtonClick);

    function getAllUsersAndScores() {
        var results = localStorage && JSON.parse(localStorage.getItem("results"));
        allUsers = {players: []};

        if (results && results.length) {
            for (var i = 0; i < results.length; i++) {
                var key = results[i].name,
                    value = results[i].score;

                allUsers.players.push({
                    name: key,
                    score: value
                });
            }
        }
    }

    function startTheGame() {
        $startButton.hide();
        $('#input-par').show();
        $resultDiv.hide();
        $winInput.hide();

        $guessNumberInput.val();
        getAllUsersAndScores();
        printTopScores();

        numberToGuess = getRandomNumber(4);
        $guessesUl.html('');
        cows = 0;
        bulls = 0;
        tries = 0;
        id++;
    }

    function onGuessButtonClick() {
        var guessNumber = $guessNumberInput.val();
        cows = 0;
        bulls = 0;
        tries++;

        if (validateValue(guessNumber)) {
            compareNumbers(guessNumber);
            printResult(guessNumber);
        }

        $guessNumberInput.val('');
    }

    function enterNameButtonClick() {
        var name = $('#name-input').val(),
            results = JSON.parse(localStorage.getItem("results")) || [];

        results.push({
            name: name,
            score: tries
        });

        localStorage.setItem("results", JSON.stringify(results));
        $startButton.trigger('click');
    }

    function getRandomNumber(length) {
        var allnumber = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
            number = '',
            currDigit,
            position;

        for (var i = 0; i < length; i++) {
            position = 'taken';

            while (position === 'taken') {
                currDigit = getCurrentDigit(i);
                position = allnumber[currDigit];
            }

            number += currDigit;
            allnumber[currDigit] = 'taken';
        }

        function getCurrentDigit(index) {
            index = index === 0 ? 1 : 0;

            return Math.floor((Math.random() * 9) + index);
        }

        return number;
    }

    function validateValue(number) {
        if (isNaN(number)) {
            alert("You should write a number!");
            return false;
        } else if (number.length != 4) {
            alert("You should write a 4-digit number!");
            return false;
        } else {
            for (var i = 0; i < number.length; i++) {
                for (var j = 1; j < number.length; j++) {
                    if (number[i] === number[i + j]) {
                        alert('You should enter a number with different digits!');
                        return false;
                    }
                }
            }
        }

        return true;
    }

    function compareNumbers(guessNumber) {
        var numbToGuess = numberToGuess.toString();

        for (var i = 0; i < guessNumber.length; i++) {
            for (var j = 0; j < numbToGuess.length; j++) {
                if (guessNumber[i] == numbToGuess[j]) {
                    if (i != j) {
                        cows++;
                    } else {
                        bulls++;
                    }
                }
            }
        }
    }

    function printResult(number) {
        $guessesUl.append('<li><strong>' + number + '</strong> - ' + cows + ' cows and ' + bulls + ' bulls' + '</li>');

        if (bulls === 4) {
            $guessesUl.html('');

            $('#name-input').val('');
            $resultDiv.show();
            $winInput.show();
        }
    }

    function printTopScores() {
        var result = $('#scores');

        if (localStorage && localStorage.results && localStorage.results.length) {
            var template = $('#template').html(),
                postTemplate = Handlebars.compile(template);

            var sorted = {players: []};
            sorted.players = _.sortBy(allUsers.players, 'score');
            result.html(postTemplate(sorted));
        } else {
            result.html('No scores yet!');
        }
    }
}());